using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection.Emit;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your UserName"); //Credentials 
            string UserName=Console.ReadLine();
            Console.WriteLine("Please Enter Your Password");
            string Password=Console.ReadLine(); 
            SortedList Sl = new SortedList(); //Registered username and password
            Sl.Add("sai", "123");  //adding username as key and password as value 
            Sl.Add("gani", "234");
            Sl.Add("sreenu", "345");
            Sl.Add("venu", "456");
            while (true)//infinite loop
            {
                if (Sl[UserName].ToString() == Password) //Checking password matched or not
                {
                    Console.WriteLine("You Login Successfully"); //Display Response
                    Thread.Sleep(2000); //Cursor retain
                    break; //terminating from the loop
                }
                else
                {
                    Console.WriteLine("Your Credentials are wrong");
                    Thread.Sleep(2000); 
                    Console.WriteLine(".....................");
                    Console.WriteLine("Please Enter Your UserName");
                    UserName = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Password");
                    Password = Console.ReadLine();
                    //Loop Repeat
                }
            }
        }
    }
}
