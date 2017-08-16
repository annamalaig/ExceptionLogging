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
        public static NextGenFMS objNextGenFMS;
        static void Main(string[] args)
        {

            string apiKey;
            apiKey = ConfigurationManager.AppSettings["apiKey"];
            ExceptionlessClient.Default.Startup(apiKey);
            
            int x = 100;
            int y = 0;
            int z=0;
            //z = x / y;
            Console.WriteLine("Result:" + z);

            objNextGenFMS = new NextGenFMS();
            objNextGenFMS.Client = "ALL Family of Companies";
            objNextGenFMS.User = "John Doe";
            objNextGenFMS.Module = "Scheduling";
            objNextGenFMS.FormName = "Create a Job Schedule";
            objNextGenFMS.Role = "Manager";
            CustomErrorLogging(objNextGenFMS);

        }

        public static void CustomErrorLogging(NextGenFMS objEx)
        {

            try
            {
                int x = 100;
                int y = 0;
                int z;
                z = x / y;
            }

            catch (Exception ex)
            {
                ex.ToExceptionless().MarkAsCritical().AddObject(objEx).Submit();
            }
        }
    }
    }
