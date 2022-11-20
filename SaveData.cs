using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YES
{
    public class SaveData
    {
        public void WriteFileAsync()
        {
            string text = "";
            string path = @"C:\Users\USER\Desktop\test2.txt";
            foreach (var data in Data.All_Periods)
            {
                text+=($"{data.Key};{data.Value}\n");
            }
            File.WriteAllText(path, text);  
        }
    }
}
