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

using System.IO;


namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {

            Crawler crawler = new Crawler("http://www.goprocut.com/knives-tools/0-4065zg-8-ka-bar-dozier-folding-hunter-w-hole-zombie-green.html", "availability out-of-stock");

            crawler.CrawlPage();
            Console.WriteLine(crawler.CrawlPage());

            Console.ReadLine();

        }
    }
}








            //var webClient = new WebClient();
            //string readHtml = webClient.DownloadString("http://www.javascriptkit.com/dhtmltutors/javascriptkit.json");
            //var a = new JavaScriptSerializer();

            //Dictionary<string, object> results = a.Deserialize<Dictionary<string, object>>(readHtml);
            //var title = results["title"].ToString(); //stores javascriptkit.com



            //WebClient c = new WebClient();
            //var data = c.DownloadString("https://www.aliexpress.com/item/0620CF-Tanto-Knife-Carbon-Fiber-3-6-Satin-Darkness-Flipper-Bearing-Folding-Knife-Camping-Survival-Pocket/32678154943.html?spm=2114.01010208.3.93.1cs0n4&ws_ab_test=searchweb0_0,searchweb201602_2_10065_10068_10084_10083_10080_10082_10081_10060_10061_10062_10056_10055_10054_10059_10099_10078_10079_10073_10100_10096_10070_10052_423_10050_10051_424,searchweb201603_8&btsid=753a820f-eb54-4421-ba4f-10b6d713161b");
            ////Console.WriteLine(data);
            //JObject o = JObject.Parse(data);

            //Console.WriteLine("Name: " + o["name"]);
            //Console.WriteLine("Email Address[1]: " + o["email"][0]);
            //Console.WriteLine("Email Address[2]: " + o["email"][1]);
            //Console.WriteLine("Website [home page]: " + o["websites"]["home page"]);
            //Console.WriteLine("Website [blog]: " + o["websites"]["blog"]);
            //Console.ReadLine();



            //using (WebClient webClient = new System.Net.WebClient())
            //    {
            //        WebClient n = new WebClient();
            //        var json = n.DownloadString("https://www.dotnetperls.com/regex-split");
            //        string valueOriginal = Convert.ToString(json);
            //        Console.WriteLine(json);
            //    }













            //var result = new System.Net.WebClient().DownloadString("https://www.aliexpress.com/item/0620CF-Tanto-Knife-Carbon-Fiber-3-6-Satin-Darkness-Flipper-Bearing-Folding-Knife-Camping-Survival-Pocket/32678154943.html?spm=2114.01010208.3.93.1cs0n4&ws_ab_test=searchweb0_0,searchweb201602_2_10065_10068_10084_10083_10080_10082_10081_10060_10061_10062_10056_10055_10054_10059_10099_10078_10079_10073_10100_10096_10070_10052_423_10050_10051_424,searchweb201603_8&btsid=753a820f-eb54-4421-ba4f-10b6d713161b");
            ////string[] arr = Regex.Split(result, ("<" || "a"));

            //string[] arr = result.Split(new Char[] { '<', '}' });

            //List<string> list = new List<string>();
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i].Contains("Free Shipping"))
            //    {
            //        list.Add(arr[i]);
            //    }




            //}


            //    foreach (var item in list)
            //    {
            //        Console.WriteLine("______________________________________________________________________________________");
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine(list.Count);

            //    Console.ReadLine();
            //}

            //private class StreamReader
            //{
            //    private Stream stream;

            //    public StreamReader(Stream stream)
            //    {
            //        this.stream = stream;
            //}
            //Console.WriteLine(TestClass.getHTML("http://www.code-bude.net"));
            


