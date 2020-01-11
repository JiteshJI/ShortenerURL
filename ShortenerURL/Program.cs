using System;

namespace ShortenerURL
{
    class Program
    {
        //C# console app that generates a URL shortener. 
        //Any URL given to it as input will return an unique shortened URL. 
        //Something like bitly or tiny.cc

        static void Main(string[] args)
        {
            char[] url = "www.amazon.com/home/index".ToCharArray();

            int limit = 12345;
            String shorturl = UrlShortener.GetShortUrl(url,limit);
            Console.WriteLine("Generated short url is " + shorturl);
            Console.Read();
        }
    }
}
