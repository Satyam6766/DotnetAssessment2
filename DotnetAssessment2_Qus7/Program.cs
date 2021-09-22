using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter name to reverse");
            
            string str = Console.ReadLine();
            string reverseString = ReverseString(str);
            //Displaying the reverse word  
            Console.WriteLine("Reverse name    "+reverseString);
            Console.ReadLine();
        }
        public static string ReverseString(string s)
        {
            string str = s;
            string rev = "";
            int length = str.Length-1;
            while (length >= 0)
            {
                rev = rev + str[length];
                length--;
            }
            return rev;
        }
    }
}
