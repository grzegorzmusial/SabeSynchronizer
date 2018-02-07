using eBdb.EpubReader;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabeSynchronizer
{
    public class Reader
    {
        public List<string> ReadEpub(string path)
        {
            //Init epub object.
            Epub epub = new Epub(path);
            List<NavPoint> navPoints = epub.TOC;
            foreach (var item in epub.TOC)
            {
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(item.ContentData.Content);
                //var doc = new HtmlDocument().LoadHtml(item.ContentData.Content);

                //var doc = new HtmlDocument();
                //doc.Load(path);

                // With XPath	
                var pNodes = doc.DocumentNode
                .SelectNodes("//p");

                foreach (var node in pNodes)
                {
                    Console.WriteLine(node.OuterHtml);
                }
                //// With LINQ	
                //var nodes = doc.DocumentNode.Descendants("input")
                //.Select(y => y.Descendants()
                //.Where(x => x.Attributes["class"].Value == "box"))
                //.ToList();
            }

            return new List<string> { "asdf" };
        }
    }
}
