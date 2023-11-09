using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList Al= new SortedList();
            while(true)
            {
                Console.WriteLine("please enter \n 1 for Adding contact \n 2 for Finding the contact of existing \n");
                int operation=Convert.ToInt32(Console.ReadLine());
                if(operation == 1)
                {
                    Console.Write("Please enter\n contact name : ");
                    string name = Console.ReadLine();
                    Console.Write(" contact phone number : ");
                    Al[name] = Console.ReadLine();
                }
               else if(operation == 2)
                {
                    Console.Write("Please enter \n contact name : ");
                    string name_ = Console.ReadLine();
                    Console.WriteLine(name_ + " phone number is " + Al[name_]);
                }
                else
                {
                    Console.WriteLine("Please select proper one");
                }
                Console.WriteLine("--------------------------");
            }
        }
    }
}
