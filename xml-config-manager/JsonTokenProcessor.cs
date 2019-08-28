using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace xml_config_manager
{
    public class JsonTokenProcessor
    {
		JObject parentNode;
		string filepath;

		public static JsonTokenProcessor ParseFile(string filepath)
		{
			JsonTokenProcessor toReturn = new JsonTokenProcessor();
			string json;

			try
			{
				json = File.ReadAllText(filepath);
				toReturn.parentNode = JObject.Parse(json);
				toReturn.filepath = filepath;
			}
			catch (Exception e)
			{
				throw e;
			}

			return toReturn;
		}

		public IEnumerable<JToken> GetChildNodes()
		{
			return parentNode.Children().AsEnumerable();
		}
    }
}
