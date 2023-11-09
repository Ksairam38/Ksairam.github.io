using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IP_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  name=Dns.GetHostName();
            string Ip_Address= Dns.GetHostEntry(name).AddressList[2].ToString();
            Console.WriteLine(" Host name is : "+name);
            Console.WriteLine("Ip Address is : " + Ip_Address);
            Console.ReadLine(); 
        }
    }
}
