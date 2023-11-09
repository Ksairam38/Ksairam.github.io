using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi sir, \n Good to see you here...\n Please enter \n 1 for Balance checking \n 2 for Cash deposition \n 3 for Cash withdrawal");
            int account = 0;
            while (true)
            {
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 1) { Console.WriteLine("your account balance is " + account);
                    Thread.Sleep(500);  
                }
                else if (operation == 2)
                {
                    Console.WriteLine("Please enter amount to deposition");
                    int depo = Convert.ToInt32(Console.ReadLine());
                    account = account + depo;
                    Thread.Sleep(500);
                    
                    Console.WriteLine("Transaction is completed\n");
                    
                }
                else if (operation == 3)
                {
                    Console.WriteLine("Please enter amount to withdrawal");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if(account>=withdraw)
                    {
                        account = account - withdraw;
                        Console.WriteLine("Transaction is completed\n");
                        Thread.Sleep(500);
                    }
                    else
                    {
                        Console.WriteLine("You don't have sufficient balance to withdraw");
                        Thread.Sleep(500);
                    }
                    
                    
                    
                }
                else
                {
                    Console.WriteLine("Please enter \n 1 for Balance checking \n 2 for Cash deposition \n 3 for Cash withdrawal");
                }
                Console.WriteLine(".......................");
            }
        }
    }
}
