using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

using HtmlAgilityPack;

using System.IO;


namespace Nop.Admin.Controllers
{
    public class Crawler
    {
        public string crawlerURL;
        public string crawlerClassName;


        public Crawler(string passedClassName, string passedURL)
        {
            this.crawlerURL = passedURL;
            this.crawlerClassName = passedClassName;
        }


        public int CrawlPage()
        {
            var matchCount = 0;

            var webGet = new HtmlWeb();

            var document = webGet.Load(crawlerURL);

            var matchesFound = document.DocumentNode.SelectNodes("//*[@class='" + crawlerClassName + "']");

            try
            {
                if (matchesFound.Count > 0)
                {
                    matchCount = 1;
                }
            }
            catch
            {
                matchCount = 0;
            }

            return matchCount;

        }
    }
}