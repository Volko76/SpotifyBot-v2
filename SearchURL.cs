using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace SpotifyBot
{
    internal class SearchURL
    {
        public SearchURL(string reasearch)
        {
            string research = reasearch;

            
        }

        private static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(fullUrl);
            return response;

        }
        public string Test(string research)
        {
            string url = "https://open.spotify.com/" + research;
            var response = CallUrl(url).Result;
            return response;
        }
        /*
        public IActionResult Index(string research)
        {
            string url = "open.spotify.com/" + research;
            var response = CallUrl(url).Result;
            return View();
        }*/

    }
}
