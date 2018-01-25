using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OnlineNeuralNetworkTrainer
{
    public class KerasModel
    {
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
            this.ClassName = className;
            this.KerasVersion = kerasVersion;
            this.Backend = backend;
            this.NumLayers = numLayers;
            this.NumNeuronLayers = numNeuronLayers;
            this.InputSize = inputSize;
        }

        public bool IsReadyForTraining()
        {
            if (this.NumLayers > 0 && Array.IndexOf(this.NumNeuronLayers,0) == -1)
            {
                return true;
            }
            return false;
        }

        public string GetModelBriefSummary()
        {
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
                Console.WriteLine("[DEBUG] at KerasModel.cs, in ExportConfig(): file writing exception: " + ex.Message);
                return false;
            }
            return true;
        }

        public void ExpandWeightsLongArray()
        {
            if (this.weightsLongArray == null || this.NumLayers == 0 || this.NumNeuronLayers.Length != this.NumLayers)
            {
                throw new ArgumentException("Unable to expand weight array");
            }
            this.weights = new List<double[,]>();
            int cursor = 0;
            //get initial weight
            double[,] WTemp = new double[this.InputSize, this.NumNeuronLayers[0]];
            for (int j = 0; j < this.NumNeuronLayers[0]; j++)
            {
                for (int k = 0; k < this.InputSize; k++)
                {
                    WTemp[k, j] = this.weightsLongArray[cursor];
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
                for (int j = 0; j < this.NumNeuronLayers[i]; j++)
                {
                    for (int k = 0; k < this.NumNeuronLayers[i - 1]; k++)
                    {
                        WTemp[k, j] = this.weightsLongArray[cursor];
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
    }
}
