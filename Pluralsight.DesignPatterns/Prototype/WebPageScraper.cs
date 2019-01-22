using System;
using System.Net;

namespace Pluralsight.DesignPatterns.Prototype
{
    class WebPageScraper : ICloneable
    {
        public string title { get; set; }
        public int headerTagCount { get; set; }
        private string firstHeaderTagContents { get; set; }

        public WebPageScraper(string url)
        {
            var client = new WebClient();
            Scrape(client.DownloadString(url));
        }

        private void Scrape(string v)
        {
            title = "Fake Title";
            headerTagCount = 3;
            firstHeaderTagContents = "Fake Header text";
        }

        public void PrintPageData()
        {
            Console.WriteLine($"Title: {title}, Header Count: {headerTagCount}, First Header: {firstHeaderTagContents}");
        }

        public object Clone()
        {
            //object is expensive to create. Cheap to copy
            return MemberwiseClone();
        }
    }
}
