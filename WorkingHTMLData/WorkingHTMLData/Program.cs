using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkingHTMLData
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = $"https://staff.am/en/companies?CompaniesFilter%5BkeyWord%5D=&CompaniesFilter%5Bindustries%5D=&CompaniesFilter%5Bindustries%5D%5B%5D=2&CompaniesFilter%5Bemployees_number%5D=&CompaniesFilter%5Bsort_by%5D=&CompaniesFilter%5Bhas_job%5D=";

            HtmlWeb hw = new HtmlWeb();

            hw.Load(url);

            //hw.Get(url, @"C:\Users\edvin.hakobyan\source\repos\Json_Serialization\WorkingHTMLData\WorkingHTMLData\bin\Debug\ttttt.txt");

            HtmlDocument ht = hw.Load(url);

            HtmlNodeCollection Hnods = ht.DocumentNode.SelectNodes("//div[@class='company-action company_inner_right']/a");

            List<string> urls = new List<string>();

            foreach (var item in Hnods)
            {
                urls.Add("https://staff.am" +  item.Attributes["href"].Value);
            }

            Console.ReadKey();


        }
    }
}
