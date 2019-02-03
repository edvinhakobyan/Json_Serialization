using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;



namespace WorkingHTMLData
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = $"https://staff.am/en/companies?CompaniesFilter%5BkeyWord%5D=&CompaniesFilter%5Bindustries%5D=&CompaniesFilter%5Bindustries%5D%5B%5D=2&CompaniesFilter%5Bemployees_number%5D=&CompaniesFilter%5Bsort_by%5D=&CompaniesFilter%5Bhas_job%5D=";
            ScrollToEnd(url);
            List<string> CompUrls = GetCompanyUrls(url);
        }




        public static string ScrollToEnd(string url)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-images");
            string directory = @"C:\Users\Edvin\source\repos\edvinhakobyan\Json_Serialization\WorkingHTMLData\WorkingHTMLData\bin\Debug";
            ChromeDriver chromeDriver = new ChromeDriver(directory, chromeOptions);
            chromeDriver.Navigate().GoToUrl(url);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    chromeDriver.ExecuteScript($"window.scrollBy(0,1750);");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Thread.Sleep(2000);
            }

            string returnVaule = chromeDriver.PageSource;
            chromeDriver.Close();
            return returnVaule;
        }

        public static List<string> GetCompanyUrls(string url)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument HD = hw.Load(url);

            //HtmlDocument HD1 = new HtmlDocument();
            //HD1.LoadHtml(url);

            return  HD.DocumentNode.SelectNodes("//div[@class='company-action company_inner_right']/a")
                                        .Select(p => "https://staff.am" + p.GetAttributeValue("href", "not found"))
                                        .ToList();
        }






    }
}
