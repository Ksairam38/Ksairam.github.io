using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Generics
{
    internal class Program
    {
        public class  Gen<tp>//Generic (class, field, array)
        {
            public tp name;
            public tp[] array=new tp[5];
        }
        static void Main(string[] args)
        {
            Gen<int> obj = new Gen<int>();
            obj.name = 10;
            obj.array[0] = 5;
            Gen<string> obj1= new Gen<string>();
            obj1.name = "sai";
            //obj1.name = 100;
            obj1.array[0] = "sai";
        }
    }
}
