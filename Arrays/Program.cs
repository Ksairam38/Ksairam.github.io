using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
