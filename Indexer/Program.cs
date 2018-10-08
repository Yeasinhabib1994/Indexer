using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "yeasin";
            Console.WriteLine(cookie["name"]);
        }
    }

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionay;

        public HttpCookie()
        {
            _dictionay = new Dictionary<string, string>();
        }

        public string this[string key] //indexer 
        {
            get { return _dictionay[key]; }
            set { _dictionay[key] = value; } //key = name, value = yeasin
        }
    }
}
