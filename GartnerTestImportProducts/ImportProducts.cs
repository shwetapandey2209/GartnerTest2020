using GartnerTestImportProducts.app;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GartnerTestImportProducts
{
    public class ImportProducts
    {
        public void LoadFile(string cmd)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var JsonfilePath = Path.Combine(outPutDirectory, "Feed-Products\\softwareadvice.json");
            var YmalFilePath = Path.Combine(outPutDirectory, "Feed-Products\\capteraa.yaml");
            if (cmd.IndexOf("capterra", StringComparison.OrdinalIgnoreCase) >=0)
            {
                new capterra(YmalFilePath);

            }
            else if (cmd.IndexOf("softwareadvice", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                new SoftwareAdvice(JsonfilePath);
            }
            else if (cmd.IndexOf("csv", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine("Class not implemented yet");
            }
            else {
                Console.WriteLine("Wrong Command");
            }

        }
    }
}
