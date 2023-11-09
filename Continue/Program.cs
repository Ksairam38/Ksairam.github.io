using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max number");
            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= max; i++)
            {
                if(i==2) { continue; }
                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
