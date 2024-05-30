using System;
using System.Text.RegularExpressions;

namespace URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string url = "https://www.apple.com/iphone";

            ParseURL(url);
        }

        static void ParseURL(string url)
        {

            string pattern = @"^(?:(?<protocol>\w+)://)?(?<server>[\w\.-]+)(?:/(?<resource>.*))?$";
            Regex regex = new Regex(pattern);


            Match match = regex.Match(url);

            if (match.Success)
            {
                string protocol = match.Groups["protocol"].Value;
                string server = match.Groups["server"].Value;
                string resource = match.Groups["resource"].Value;
                Console.WriteLine("[protocol] = \"{0}\"", string.IsNullOrEmpty(protocol) ? "None" : protocol);
                Console.WriteLine("[server] = \"{0}\"", server);
                Console.WriteLine("[resource] = \"{0}\"", string.IsNullOrEmpty(resource) ? "None" : resource);
            }
            else
            {
                Console.WriteLine("Invalid URL format.");
            }
        }
    }
}