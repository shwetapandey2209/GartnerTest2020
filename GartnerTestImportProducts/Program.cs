using GartnerTestImportProducts.app;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GartnerTestImportProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Command to Load the file");
            String loadCommand = Console.ReadLine();
            ImportProducts ip = new ImportProducts();
            ip.LoadFile(loadCommand);          
          
        }
    }
}
