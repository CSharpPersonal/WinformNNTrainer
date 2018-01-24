/*--------------------------------------------------
 * System Manager stores all global variable and 
 * static reference
 -------------------------------------------------*/

using System;
using System.Linq;

namespace OnlineNeuralNetworkTrainer
{
    public static class SystemManager
    {
        public static string SoftwareVersion = "1.0.0";
        public static KerasModel CurrentKerasModel;
        public static KerasModel TempKerasModel = new KerasModel("TBD", "TBD", "TBD", 0,new int[] { });

        public static string DeleteLines(string s, int linesToRemove)
        {
            return s.Split(Environment.NewLine.ToCharArray(),
                           linesToRemove + 1
                ).Skip(linesToRemove)
                .FirstOrDefault();
        }
    }
}
