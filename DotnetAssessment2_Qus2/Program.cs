using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine("Enter year to find is it leap year ?");
            int year = Convert.ToInt32(Console.ReadLine());
            string result = obj.isLeapYear(year);
            if (result == "LP")
            {
                Console.WriteLine("It is Leap Year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.ReadLine();
        }
    }
    class Test
    {
        public string isLeapYear(int y)
        {
            string result;
            
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                result = "LP";
            }
            else
            {
                result = "NLP";
            }
            return result;
            
        }
    }
}
