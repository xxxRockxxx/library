using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YES
{
    public class SaveData
    {
        public void WriteFileAsync()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //string Data = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SaveFile(saveFileDialog1.FileName);
            }
            //string path = saveFileDialog1.FileName;
            //string text = "";
            //File.WriteAllText(path, text);
            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            //string filename= saveFileDialog1.FileName;
            //string text = "";
            //string path = @"C:\Users\USER\Desktop\test2.txt";
            //foreach (var data in Data.All_Periods)
            //{
            //    text+=($"{data.Key};{data.Value}\n");
            //}
            //File.WriteAllText(path, text);  
        }
    }
}
