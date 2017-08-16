using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptionless;
using System.Configuration;

namespace ErrorLogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey;
            apiKey = ConfigurationManager.AppSettings["apiKey"];
            ExceptionlessClient.Default.Startup(apiKey);
            int x=100;
            int y=0;
            int z;
            z = x / y;
            Console.WriteLine("Result:" + z);

        }
    }
}
