
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    internal class Program
    {
        int Age,Rno;
        string Name,surname;

        public Program(int a, string b)
        {
            Age= a;
            Name = b;
        }
        public Program(Program ol)
        {
            Rno = ol.Age;
            surname = ol.Name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program(21,"sai");
            Program obj1= new Program(obj);
            Console.WriteLine(obj1.Rno);
            Console.ReadLine();
        }
    }
}
