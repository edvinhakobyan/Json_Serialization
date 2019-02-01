using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;

namespace Json_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
           Company[] companies = JsonReader.GetCompanies(@"https://www.itjobs.am/api/v1.0/companies");

           companies.ToList().ForEach(x => Console.WriteLine(x));

           Console.ReadKey();
        }
    }
}
