using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add("sai");
            al.Add("gani");
            al.Insert(0, true);
            al.Add(false);
            al.Add(10);
            foreach (var i in al)
            {
                Console.WriteLine(i);   
            }
            al.Remove("sai");
            al.RemoveAt(0);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            al.Clear();
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
           
        }
    }
}
