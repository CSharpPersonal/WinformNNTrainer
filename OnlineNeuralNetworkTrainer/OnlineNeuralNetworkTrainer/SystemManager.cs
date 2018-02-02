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
        public static DataBaseManager dbm = new DataBaseManager();
        public static KerasModel TempKerasModel = new KerasModel("TBD", "TBD", "TBD", 0,new int[] { },0);

        public static string DeleteLines(string s, int linesToRemove)
        {
            return s.Split(Environment.NewLine.ToCharArray(),
                           linesToRemove + 1
                ).Skip(linesToRemove)
                .FirstOrDefault();
        }
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
