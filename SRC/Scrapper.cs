/*
    $ ProxyScrapper $
    Author > github.com/L1ghtM4n
    Donate > 1Lightx1nLy6DfH3W8WD1g4PugRu92M7GV (Bitcoin)
*/


using System;
using System.Net;

namespace ProxyScrapper
{
    internal sealed class Scrapper
    {
        public static string[] Search(string type, string country)
        {
            string endpoint = "https://www.proxy-list.download/api/v1/get?";
            if (country.Equals("All"))
            {
                endpoint = string.Format(
                    "{0}type={1}",
                    endpoint, type.ToLower()
                );
            } else
            {
                endpoint = string.Format(
                    "{0}type={1}&country={2}",
                    endpoint, type.ToLower(), country.ToUpper()
                );
            }
            
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Set(HttpRequestHeader.UserAgent, "L1ghtMan ProxieScrapper 1.0");
                string response = wc.DownloadString(endpoint);
                return response.Split(
                    new char[] { '\n', '\r' }, 
                    StringSplitOptions.RemoveEmptyEntries
                );
            }
        }
    }
}
