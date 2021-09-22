using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus8
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            //t1.PrintTable();
            t1.PrintTable_RecursiveMethod();

            Console.ReadLine();
        }
    }
    class Test
    {
        public void PrintTable_RecursiveMethod()
        {
            Console.WriteLine("Table of 1");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + (i * j));
                }
                Console.WriteLine();
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine("Table of " + (i + 1));
            }


        }
        //public void PrintTable()
        //{
        //    Console.WriteLine("1 table");
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("1 * " + i + "=" + (1 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("2 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("2 * " + i + "=" + (2 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("3 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("3 * " + i + "=" + (3 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("4 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("4 * " + i + "=" + (4 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("5 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("5 * " + i + "=" + (5 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("6 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("6 * " + i + "=" + (6 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("7 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("7 * " + i + "=" + (7 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("8 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("8 * " + i + "=" + (8 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("9 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("9 * " + i + "=" + (9 * i));
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("10 table");
        //    Console.WriteLine();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("10 * " + i + "=" + (10 * i));
        //    }

        //}
        
    }
}
