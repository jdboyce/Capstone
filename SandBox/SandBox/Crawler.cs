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


namespace SandBox
{
    public class Crawler
    {
        public string crawlerURL;
        public string crawlerClassName;


        public Crawler(string passedURL, string passedClassName)
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

            if (matchesFound.Count > 0)
                {
                    matchCount = 1;
                    foreach (var item in matchesFound)
                    {
                        Console.WriteLine("Yay");
                        Console.WriteLine(item.Attributes);
                    }
                }

            else
                {
                    matchCount = 0;
                    Console.WriteLine("Boo");
                }

            return matchCount;

            }
        }
    }


























