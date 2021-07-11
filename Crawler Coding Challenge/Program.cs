using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace Crawler_Coding_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = new WebClient().DownloadString("https://en.wikipedia.org/wiki/Microsoft");
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var divs = htmlDocument.DocumentNode.Descendants("div").Where(w => w.GetAttributeValue("class", "").Equals("mw-parser-output")).ToList();

            try
            {
                string str = divs[0].InnerHtml;

                string start = "id=\"History\">";
                string end = "id=\"Corporate_affairs\">";
                str = str.Substring(str.IndexOf(start) + 13, str.IndexOf(end) - str.IndexOf(start) - 39);

                Regex regex = new Regex("\\<[^\\>]*\\>");
                string.Format("Before:{0}", str);
                str = regex.Replace(str, string.Empty);

                foreach (var item in TopTen(str.Split(' ', '\t', '\n')))
                {
                    Console.WriteLine(string.Format("{0}\t |{1}\t|", item.Key, item.Value));
                } 

            }
            catch (Exception e)
            {

                Console.WriteLine("error : - " + e.Message);
            }

            Console.ReadKey();

        }

        public static Dictionary<string, int>? TopTen(string[] arr)
        {
            if (arr.Length == 0) return null;

            Dictionary<string, int> dic = new Dictionary<string, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]] += 1;
                }
                else
                {
                    dic[arr[i]] = 1;
                }
            }

            return dic.OrderByDescending(entry => entry.Value)
                     .Take(10)
                     .ToDictionary(pair => pair.Key, pair => pair.Value);

        }




    }
}
