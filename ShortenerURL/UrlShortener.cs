using System.Text;

namespace ShortenerURL
{
    public class UrlShortener
    {

        public static string GetShortUrl(char[] url, int counter)
        {
            StringBuilder shortUrl = new StringBuilder();
            int mod = url.Length;
            while (counter > 0)
            {
                shortUrl.Append(url[counter % mod]);
                counter = counter / mod;
            }

            return shortUrl.ToString();
        }
    }

}
