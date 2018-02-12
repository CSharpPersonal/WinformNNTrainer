using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace OnlineNeuralNetworkTrainer
{
    public class JSONReader
    {
        private readonly string debugTAG = "[JR]";
        public JSONReader()
        {}

        public KerasModel ReadArchitectureFromJsonFile(string filename)
        {
            SystemManager.Log(this.debugTAG, "reading model architechture", false);
            string jsonString = File.ReadAllText(filename);
            dynamic json = Newtonsoft.Json.Linq.JToken.Parse(jsonString) as dynamic;
            int NumLayers = json.config.Count;
            int[] NumLayerNeurons = new int[NumLayers-1];
            int inputSize = json.config[0].config.batch_input_shape[1];
            for (int i = 1; i < NumLayers; i++)
            {
                NumLayerNeurons[i-1] = json.config[i].config.batch_input_shape[1];
            }
            KerasModel km = new KerasModel(json.class_name.Value,json.keras_version.Value, json.backend.Value, NumLayers-1,NumLayerNeurons, inputSize);
            return km;
        }

        public double[] ReadWeightsFromJsonFile(string filename)
        {
            SystemManager.Log(this.debugTAG, "reading model weights", false);
            string jsonString = File.ReadAllText(filename);
            dynamic json = Newtonsoft.Json.Linq.JToken.Parse(jsonString) as dynamic;
            string WeightsStr = json.Value;
            WeightsStr = WeightsStr.Replace('[', ' ');
            WeightsStr = WeightsStr.Replace(']', ' ');
            WeightsStr = WeightsStr.Replace('"', ' ');
            double[] WeightsLongArray = WeightsStr.Split(',').Select(r => Convert.ToDouble(r)).ToArray();
            return WeightsLongArray;
        }
    }
}
