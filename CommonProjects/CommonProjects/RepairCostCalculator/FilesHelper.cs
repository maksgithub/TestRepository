using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace RepairCostCalculator
{
    class FilesHelper
    {

        public void AppendTextToFile(string path, string text)
        {
            if (text != null)
            {
                if (!File.Exists(path))
                {
                    string addText = text + Environment.NewLine;
                    File.WriteAllText(path, addText, Encoding.UTF8);
                }
                string appendText = text + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }
        }
    }
}
