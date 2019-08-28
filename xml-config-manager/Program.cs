using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_config_manager
{
    class Program
    {
        static void Main(string[] args)
        {
			if (args == null || args.Length == 0)
			{
				Console.WriteLine("------------------");
				Console.WriteLine("Usage:");
				Console.WriteLine("xml-config-manager valueFile transformFile xmlFile outFolder");
				Console.WriteLine("------------------");
				return;
			}

			// programCall valueFile transformFile xmlFile outFolder
			string valueFilepath = args[0];
			string transformFilepath = args[1];
			string xmlFilepath = args[2];
			string outDirFilepath = args[3];
		}
    }
}
