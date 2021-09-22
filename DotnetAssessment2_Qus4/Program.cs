using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Object obj = a;   //Boxing 
            Console.WriteLine(obj);
            Console.WriteLine("Here we convert int type to Object type,so this is refered to as Boxing");
            Console.WriteLine();

            Object b = 10;
            int c = (int)b; //UnBoxing
            Console.WriteLine(c);
            Console.WriteLine("Here we convert Object type to int type,so this is refered to as UnBoxing");

            Console.ReadLine(); 
        }
    }
}
