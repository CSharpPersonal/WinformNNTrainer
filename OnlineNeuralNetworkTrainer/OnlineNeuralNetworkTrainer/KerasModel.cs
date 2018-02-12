using System;
using System.Collections.Generic;
using System.IO;
//using ApplyKerasModule;
//using MathNet.Numerics.LinearAlgebra;
//using MathNet.Numerics.LinearAlgebra.Double;
using Accord.Math;
using System.Linq;

namespace OnlineNeuralNetworkTrainer
{
    public class KerasModel
    {
        private readonly string debugTAG = "[KM]";
        public string ClassName;
        public string KerasVersion;
        public string Backend;
        public int InputSize;
        public int NumLayers;
        public int[] NumNeuronLayers;
        public int batch_size = 10;
        public string optim_func = "adam";
        public string loss_func = "mape";
        public List<double[,]> weights;
        public double[] weightsLongArray;

        public KerasModel(string className, string kerasVersion, string backend, int numLayers, int[] numNeuronLayers, int inputSize)
        {
            SystemManager.Log(this.debugTAG, "Keras model initialising", false);
            this.ClassName = className;
            this.KerasVersion = kerasVersion;
            this.Backend = backend;
            this.NumLayers = numLayers;
            this.NumNeuronLayers = numNeuronLayers;
            this.InputSize = inputSize;
        }

        public bool IsReadyForTraining()
        {
            SystemManager.Log(this.debugTAG, "checking if model is ready to train", false);
            if (this.NumLayers > 0 && Array.IndexOf(this.NumNeuronLayers,0) == -1)
            {
                return true;
            }
            return false;
        }

        public string GetModelBriefSummary()
        {
            SystemManager.Log(this.debugTAG, "getting model summary", false);
            string summary = "-----------Loaded Model-----------\n";
            summary += "Keras Version: " + this.KerasVersion + "\n";
            summary += "Backend Engine: " + this.Backend + "\n";
            summary += "Input Size: " + this.InputSize + "\n";
            summary += "Number of Layers: " + this.NumLayers.ToString() + "\n";
            for (int i = 0; i < this.NumLayers; i++)
            {
                summary += "Layer " + (i+1).ToString() + " neurons: " + this.NumNeuronLayers[i].ToString() + "\n";
                if (i >= 4)
                {
                    summary += "......\n";
                    break;
                }
            }
            return summary;
        }

        public bool ExportConfig(string path)
        {
            SystemManager.Log(this.debugTAG, "exporting config", false);
            string outputStr = "";
            outputStr += "Layers=" + this.NumLayers + "\r\n";
            for (int i = 0; i < this.NumLayers; i++)
            {
                outputStr += "Layer" + (i+1).ToString() + "_neurons=" + this.NumNeuronLayers[i].ToString() + "\r\n";
            }
            outputStr += "batch_size=" + this.batch_size.ToString() + "\r\n";
            outputStr += "optim_func=" + this.optim_func.ToString() + "\r\n";
            outputStr += "loss_func=" + this.loss_func.ToString();
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                File.WriteAllText(path + "//config.txt", outputStr);
            }
            catch (Exception ex)
            {
                SystemManager.Log(this.debugTAG, "export config failed, exception: "+ex.Message, true);
                Console.WriteLine("[DEBUG] at KerasModel.cs, in ExportConfig(): file writing exception: " + ex.Message);
                return false;
            }
            return true;
        }

        public void ExpandWeightsLongArray()
        {
            SystemManager.Log(this.debugTAG, "expanding weight array to matrix", false);
            if (this.weightsLongArray == null || this.NumLayers == 0 || this.NumNeuronLayers.Length != this.NumLayers)
            {
                throw new ArgumentException("Unable to expand weight array");
            }
            this.weights = new List<double[,]>();
            int cursor = 0;
            //get initial weight
            double[,] WTemp = new double[this.InputSize, this.NumNeuronLayers[0]];
            for (int j = 0; j < this.InputSize; j++)
            {
                for (int k = 0; k < this.NumNeuronLayers[0]; k++)
                {
                    WTemp[j, k] = this.weightsLongArray[cursor];
                    cursor++;
                }
            }
            this.weights.Add(WTemp);
            //get initial bias
            double[,] bTemp = new double[1,this.NumNeuronLayers[0]];
            for (int i = 0; i < this.NumNeuronLayers[0]; i++)
            {
                bTemp[0,i] = this.weightsLongArray[cursor];
                cursor++;
            }
            this.weights.Add(bTemp);
            for (int i = 1; i < this.NumLayers; i++)
            {
                //get weight
                WTemp = new double[this.NumNeuronLayers[i-1], this.NumNeuronLayers[i]];
                for (int j = 0; j < this.NumNeuronLayers[i - 1]; j++)
                {
                    for (int k = 0; k < this.NumNeuronLayers[i]; k++)
                    {
                        WTemp[j,k] = this.weightsLongArray[cursor];
                        cursor++;
                    }
                }
                this.weights.Add(WTemp);
                //get bias
                bTemp = new double[1,this.NumNeuronLayers[i]];
                for (int j = 0; j < this.NumNeuronLayers[0]; j++)
                {
                    bTemp[0,j] = this.weightsLongArray[cursor];
                    cursor++;
                }
                this.weights.Add(bTemp);
            }
            //get final weight
            WTemp = new double[1, this.NumNeuronLayers[this.NumLayers-1]];
            for (int i = 0; i < this.NumNeuronLayers[this.NumLayers - 1]; i++)
            {
                WTemp[0, i] = this.weightsLongArray[cursor];
                cursor++;
            }
            this.weights.Add(WTemp);
            //get final bias
            bTemp = new double[1, 1];
            bTemp[0, 0] = this.weightsLongArray[cursor];
            this.weights.Add(bTemp);
        }

        public double Predict(double[] inputsArray)
        {
            SystemManager.Log(this.debugTAG, "performing predict", false);
            double result = 0;
            // Matlab generate library is causeing SystemViolationException - FIX later
            /*
            double[] resultWrapper = new double[] { };
            if (this.weightsLongArray == null || this.NumNeuronLayers == null)
            {
                throw new ArgumentNullException("null reference when wrapping a nonull value");
            }
            else
            {
                ApplyKerasModule.ApplyKerasModule akm = new ApplyKerasModule.ApplyKerasModule();
                akm.GetPrediction(inputsArray, weightsLongArray, Array.ConvertAll<int,double>(NumNeuronLayers,d=>(double)d),ref resultWrapper);
            }
            */

            //C# version

            double[,] inputsArrayMat = new double[inputsArray.Length,1];
            for (int i = 0; i < inputsArray.Length; i++)
            {
                inputsArrayMat[i, 0] = inputsArray[i];
            }
            double[,] tempVar = Matrix.Dot(Transpose(weights[0]), inputsArrayMat);
            tempVar = sigmoid(Elementwise.Add(tempVar, Transpose(weights[1])));
            for (int i = 1; i < this.NumLayers; i++)
            {
                tempVar = Matrix.Dot(Transpose(weights[2*i]), tempVar);
                tempVar = sigmoid(Elementwise.Add(tempVar, Transpose(weights[2 * i + 1])));
            }
            tempVar = Matrix.Dot(weights[2 * this.NumLayers], tempVar);
            tempVar = sigmoid(Elementwise.Add(tempVar, weights[2 * this.NumLayers + 1]));
            result = tempVar[0, 0];
            return result;
        }

        private double sigmoid(double input)
        {
            double output = 0;
            output = 1.0 / (1 + Math.Exp(-input));
            return output;
        }

        private double[,] sigmoid(double[,] Mat)
        {
            double[,] MatOut = new double[Mat.GetLength(0), Mat.GetLength(1)];
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    MatOut[i, j] = sigmoid(Mat[i, j]);
                }
            }
            return MatOut;
        }

        private double[,] Transpose(double[,] Mat)
        {
            double[,] MatOut = new double[Mat.GetLength(1), Mat.GetLength(0)];
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    MatOut[j, i] = Mat[i, j];
                }
            }
            return MatOut;
        }
    }
}
