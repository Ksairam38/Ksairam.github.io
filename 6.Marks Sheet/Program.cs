using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Marks_Sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           ArrayList al = new ArrayList();
           
                Console.Write("Name : ");
                string Name = Console.ReadLine();
                Console.Write("Roll Number : ");
                string Roll = Console.ReadLine();
                int t, e, h, m, p, c, s;
                string Result;
            al.Add($"Name : {Name}\nRoll No :{Roll}");
                Console.Write("Telugu Marks : ");
                t = int.Parse(Console.ReadLine());
              if (t >= 35)
              {
                Result = "Pass";
            }
            else
            {
                Result = "Fail";
            }
            al.Add($"Telugu\t{t}\t{Result}");

            Console.Write("English Marks : ");  
                e = int.Parse(Console.ReadLine());
            if (e >= 35)
            {
                Result = "Pass";
            }
            else
            {
                Result = "Fail";
            }
            al.Add($"English\t{e}\t{Result}");
            Console.Write("Hindi Marks : ");
                h = int.Parse(Console.ReadLine());
            if (h>= 35)
            {
                Result = "Pass";
            }
            else
            {
                Result = "Fail";
            }
            al.Add($"Hindi\t{h}\t{Result}");
            Console.Write("Maths Marks : ");
                m = int.Parse(Console.ReadLine());
            if (m >= 35)
            {
                Result = "Pass";
            }
            else
            {
                Result = "Fail";
            }
            al.Add($"Maths\t{m}\t{Result}");
            Console.Write("Physics Marks : ");
                p = int.Parse(Console.ReadLine());
            if (p >= 35)
            {
                Result = "Pass";
            }
            else
            {
                Result = "Fail";
            }
            al.Add($"Physics\t{p}\t{Result}");  
            Console.Write("Chemistry Marks : ");
                c = int.Parse(Console.ReadLine());
            if (c >= 35)
            {
                Result = "Pass";
            }
            else
            {
                Result = "Fail";
            }
            al.Add($"Chemist\t{c}\t{Result}");
            Console.Write("Social Marks : ");
                s = int.Parse(Console.ReadLine());
                
                if(s>=35)
                {
                    Result = "Pass";
                }
                else
                {
                    Result = "Fail";
                }
                al.Add($"Social\t{s}\t{Result}");

            Console.WriteLine("\n\n\n"+al[0]);
            Console.WriteLine();
            Console.WriteLine("Subject\tMarks\tResult");
            Console.WriteLine("------------------");
              foreach (var student in al)
            {
                if(student == al[0]) { continue; }
                Console.WriteLine(student);
            }
            string Total_Result;
            if(t<35 && h<35 && e<35 && p<35 && c<35 && m<35 && s < 35)
            {
                Total_Result = "Fail";
            }
            else
            {
                Total_Result = "Pass";
            }
            Console.WriteLine($"\n\nTotal\t{t + h + e + p + c + s + m}\t{Total_Result}");
            Console.ReadLine();
        }
    }
}
