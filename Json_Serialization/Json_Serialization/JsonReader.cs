using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Json_Serialization
{
    static class JsonReader
    {
        public static string GetJsonData(string url)
        {
            WebClient webC = new WebClient();

            Stream str = webC.OpenRead(url);

            StreamReader st = new StreamReader(str);

            return st.ReadToEnd();
        }

        public static Company[] GetCompanies(string url)
        {
            return JsonConvert.DeserializeObject<Company[]>(GetJsonData(url));
        }
    }
}
