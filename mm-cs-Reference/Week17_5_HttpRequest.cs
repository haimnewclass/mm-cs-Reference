using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Net.Http;

namespace mm_cs_Reference
{
    internal class Week17_5_HttpRequest
    {
        public async void Run()
        {
            string url = "https://rss.walla.co.il/feed/2689";
            using (var client = new HttpClient())
            {                        
                var response = await client.GetAsync(url);
               
                response.EnsureSuccessStatusCode();

                
                var content = await response.Content.ReadAsStringAsync();

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(content);

                foreach (XmlNode node in doc.SelectNodes("//item"))
                {
                    //string title = node.SelectNodes("title")[0].InnerText;
                    string title = node["title"].InnerText;
                    //string link = node.SelectNodes("link")[0].InnerText;
                    string link = node["link"].InnerText;
                }
                
                Console.WriteLine(content);
            }
        }
    }
}
