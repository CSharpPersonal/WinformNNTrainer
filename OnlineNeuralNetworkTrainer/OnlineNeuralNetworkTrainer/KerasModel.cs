using System;
using System.IO;
using System.Windows.Forms;

namespace OnlineNeuralNetworkTrainer
{
    public class KerasModel
    {
        public string ClassName;
        public string KerasVersion;
        public string Backend;
        public int NumLayers;
        public int[] NumNeuronLayers;
        public int batch_size = 100;
        public string optim_func = "adam";
        public string loss_func = "mape";

        public KerasModel(string className, string kerasVersion, string backend, int numLayers, int[] numNeuronLayers)
        {
            this.ClassName = className;
            this.KerasVersion = kerasVersion;
            this.Backend = backend;
            this.NumLayers = numLayers;
            this.NumNeuronLayers = numNeuronLayers;
        }

        public string GetModelBriefSummary()
        {
            string summary = "-----------Loaded Model-----------\n";
            summary += "Keras Version: " + this.KerasVersion + "\n";
            summary += "Backend Engine: " + this.Backend + "\n";
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
            outputStr += "Layers=" + this.NumLayers + "\n";
            for (int i = 0; i < this.NumLayers; i++)
            {
                outputStr += "Layer" + (i+1).ToString() + "_neurons=" + this.NumNeuronLayers[i].ToString() + "\n";
            }
            outputStr += "batch_size=" + this.batch_size.ToString() + "\n";
            outputStr += "optim_func=" + this.optim_func.ToString() + "\n";
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
    }
}
