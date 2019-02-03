using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace youtube.com
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomurl = @"https://www.youtube.com/watch?v=pa7GRczb63I";

            HtmlWeb web = new HtmlWeb();

            HtmlDocument hd = web.Load(randomurl);
        }
    }
}
