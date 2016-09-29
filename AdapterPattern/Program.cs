using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            var oSMSCore = new SMSCore();
            message = oSMSCore.ComposeSMS();



            Console.WriteLine("SMS Composition Started........");
            Console.WriteLine(message);

            message = oSMSCore.SendSMS();



            Console.WriteLine("SMS Sending.........");
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
