using GartnerTestImportProducts.Interfaces;
using GartnerTestImportProducts.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerTestImportProducts.app
{
   public class SoftwareAdvice : INormalizeData
    {
        public SoftwareAdvice(string filepath)
        {
            LoadData(filepath);
        }

        public void LoadData(string filePath)
        {
            string localPath = new Uri(filePath).LocalPath;
            string json = new StreamReader(localPath).ReadToEnd();
            try
            {
                var jObject = JObject.Parse(json);
                JArray ProductsArrary = (JArray)jObject["products"];
                if (ProductsArrary != null)
                {
                    foreach (var item in ProductsArrary)
                    {
                        Console.WriteLine("Categories :" + item["categories"]);
                        Console.WriteLine("Title :" + item["title"].ToString());
                        Console.WriteLine("Twitter :" + item["twitter"].ToString());
                    }

                }

            }
            catch (Exception)
            {
                //throw;
            }
 

            //Products pro = JsonConvert.DeserializeObject<Products>(json);
            //var resultJson = JsonConvert.SerializeObject(pro, Formatting.Indented);
            //Console.WriteLine(resultJson);
            Console.ReadLine();
        }

    }
   
}
