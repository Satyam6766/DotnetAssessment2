using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus1
{
    class Program
    {

        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.a = 10;
            Console.WriteLine(t1.a + " Here it is non static field so we use it with help of object"); //Here it is non static field so we use it with help of object.

            Test1.b = 5;
            Console.WriteLine(Test1.b+ " Here it is static field so we can it directly with the help of className.property.");//Here it is static field so we can it directly with the help of className.property.

            Console.ReadLine();



        }
    }
    class Test
    {
        public int a { get; set; }

    }
    static class Test1
    {
        public static int b { get; set; }

    }

}

