using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace OnlineNeuralNetworkTrainer
{
    public class JSONReader
    {
        public JSONReader()
        {}

        public KerasModel ReadArchitectureFromJsonFile(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            dynamic json = Newtonsoft.Json.Linq.JToken.Parse(jsonString) as dynamic;
            int NumLayers = json.config.Count;
            int[] NumLayerNeurons = new int[NumLayers-1];
            for (int i = 1; i < NumLayers; i++)
            {
                NumLayerNeurons[i-1] = json.config[i].config.batch_input_shape[1];
            }
            KerasModel km = new KerasModel(json.class_name.Value,json.keras_version.Value, json.backend.Value, NumLayers-1,NumLayerNeurons);
            return km;
        }
    }
}
