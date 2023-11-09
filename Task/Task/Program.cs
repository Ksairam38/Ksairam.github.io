using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi sir, \n good to see you here..\n Please enter \n 1 for Balance checking \n 2 for Cash deposition \n 3 for Cash withdrawal");
            int account=0;
            while(true)
            {
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 1) { Console.WriteLine("your account balance is "+account); }
                else if (operation == 2)
                {
                    Console.WriteLine("Please enter amount to deposition");
                    int depo = Convert.ToInt32(Console.ReadLine());
                    account = account + depo;
                    Console.WriteLine("Transaction is completed");
                }
                else if (operation == 3)
                {
                    Console.WriteLine("Please enter amount to withdrawal");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    account = account - withdraw;
                    Console.WriteLine("Transaction is completed");
                }
                Console.WriteLine(".......................");
            }
        }
    }
}
