using GartnerTestImportProducts.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;

namespace GartnerTestImportProducts.app
{
    public class capterra : INormalizeData
    {


        public capterra(string filepath)
        {
            LoadData(filepath);
        }

        public void LoadData(string filePath)
        {
            //byte[] byteArray = Encoding.UTF8.GetBytes(filePath);

            //MemoryStream stream = new MemoryStream(byteArray);
            string localPath = new Uri(filePath).LocalPath;
            try
            {
                using (var reader = new StreamReader(localPath))
                {
                    var yaml = new YamlStream();
                    yaml.Load(reader);
                    var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;

                    foreach (var entry in mapping.Children)
                    {
                        Console.WriteLine(((YamlScalarNode)entry.Key).Value);
                    }

                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            }
    }
}
