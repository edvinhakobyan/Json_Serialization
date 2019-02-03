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
            GetCompanyUrls(randomurl);

            HtmlWeb web = new HtmlWeb();

            HtmlDocument hd = web.Load(randomurl);
        }

        //WebView webView = new WebView();
        //webView.Navigate(new Uri(@"https://www.youtube.com/results?search_query=cado+dalle+nubi+trailer+ita"));

        // private async void WebView_NavigationCompletedAsync(WebView sender, WebViewNavigationCompletedEventArgs args)
        //{
        //    var siteHtML = await webView.InvokeScriptAsync("eval", new string[] { "document.documentElement.innerHTML;" });
        //}

        public static List<string> GetCompanyUrls(string url)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument HD = hw.Load(url); //"//div[@id='dismissable']/a[0]"

            string tt = HD.Text;

            List<HtmlNode> ret = HD.DocumentNode.Descendants("div").
                               Where(item => item.GetAttributeValue("id", "").
                               Equals("dismissable")).ToList();
            return null;
        }
    }
}
