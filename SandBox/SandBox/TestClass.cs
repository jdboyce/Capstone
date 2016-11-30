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
    class TestClass
    {


       public void Run()
        {
            var webGet = new HtmlWeb();

            //http://www.4guysfromrolla.com/articles/011211-1.aspx
            var document = webGet.Load("https://www.aliexpress.com/item/0620CF-Tanto-Knife-Carbon-Fiber-3-6-Satin-Darkness-Flipper-Bearing-Folding-Knife-Camping-Survival-Pocket/32678154943.html?spm=2114.01010208.3.93.1cs0n4&ws_ab_test=searchweb0_0,searchweb201602_2_10065_10068_10084_10083_10080_10082_10081_10060_10061_10062_10056_10055_10054_10059_10099_10078_10079_10073_10100_10096_10070_10052_423_10050_10051_424,searchweb201603_8&btsid=753a820f-eb54-4421-ba4f-10b6d713161b");
            var metaTags = document.DocumentNode.SelectNodes("//div[contains(.,'shipping')]");
            //*[text()[contains(., 'shipping')]]");
            Console.WriteLine("____________________________________________________________________");
            if (metaTags != null)
            {
                foreach (var tag in metaTags)
                {
                    if (tag.Attributes["name"] != null && tag.Attributes["content"] != null)
                    {
                        Console.WriteLine("Name: " + tag.Attributes["name"].Value + "\nContent: "
                            + tag.Attributes["content"].Value + "\n\n");
                    }
                }
            }



            foreach (var item in metaTags)
            {
                try
                {

                    foreach (var att in item.Attributes)

                    {
                        Console.WriteLine(att.Value + ", " + att.Name + ", " + att.LinePosition);
                    }

                }
                catch
                {
                    Console.WriteLine("Empty");
                }




                //    var webGet = new HtmlWeb();
                //var document = webGet.Load("http://www.4guysfromrolla.com");

                //var body = document.DocumentNode.Descendants().Where(n => n.Name == "body").FirstOrDefault();

                //if (body != null)
                //{
                //    var messageElement = new HtmlNode(HtmlNodeType.Element, document, 0);
                //    messageElement.Attributes.Add("style", "width:95%;border:solid black 2px;background-color:#ffc;font-size:xx-large;text-align:center");
                //    messageElement.Name = "div";
                //    messageElement.InnerHtml = "<p>Hello! This page was modified by the Html Agility Pack!</p><p>Click on a link below... it should open in a new window!</p>";

                //    body.ChildNodes.Insert(0, messageElement);
                //}

                //var linksThatDoNotOpenInNewWindow = document.DocumentNode.SelectNodes("//a[@href]");
                //if (linksThatDoNotOpenInNewWindow != null)
                //{
                //    foreach (var link in linksThatDoNotOpenInNewWindow)
                //        if (link.Attributes["target"] == null)
                //            link.Attributes.Add("target", "_blank");
                //        else
                //            link.Attributes["target"].Value = "_blank";
                //}


                //var fileName = string.Format("~/ModifiedPages/{0}.htm", Guid.NewGuid().ToString());
                //document.Save(C:\Users\Owner\Desktop);

            }
        }
    }

}

       
























        //public static string getHTML(string url)
        //{
        //    //Create request for given url
        //    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

        //    //Create response-object
        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //    //Take response stream
        //    StreamReader sr = new StreamReader(response.GetResponseStream());

        //    //Read response stream (html code)
        //    string html = sr.ReadToEnd();

        //    //Close streamreader and response
        //    sr.Close();
        //    response.Close();

        //    //return source
        //    return html;
        //}

