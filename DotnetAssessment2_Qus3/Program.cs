using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character to find is it vowel or constant.");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Using which method You want to find out.");
            Console.WriteLine("Input 0 for SwitchCase and 1 for ifElse");
            int method = Convert.ToInt32(Console.ReadLine());
            if (method == 0)
            {
                usingSwitchCase obj1 = new usingSwitchCase();
                obj1.demo(ch);
            }
            else
            {
                usingIfElse obj2 = new usingIfElse();
                obj2.demo(ch);
            }
        }
    }
    class usingSwitchCase
    {
        public void demo(char ch)
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;

                case 'o':
                    Console.WriteLine("vowel");
                    break;

                case 'u':
                    Console.WriteLine("vowel");
                    break;

                case 'A':
                    Console.WriteLine("vowel");
                    break;

                case 'E':
                    Console.WriteLine("vowel");
                    break;

                case 'I':
                    Console.WriteLine("vowel");
                    break;

                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;

            }
            Console.ReadLine();
        }
    }
    class usingIfElse
    {
        public void demo(char ch)
        {
            if (ch == 'a')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                if (ch == 'e')
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    if (ch == 'i')
                    {
                        Console.WriteLine("vowel");
                    }
                    else
                    {
                        if (ch == 'o')
                        {
                            Console.WriteLine("vowel");
                        }
                        else
                        {
                            if (ch == 'u')
                            {
                                Console.WriteLine("vowel");
                            }
                            else
                            {
                                if (ch == 'A')
                                {
                                    Console.WriteLine("vowel");
                                }
                                else
                                {
                                    if (ch == 'E')
                                    {
                                        Console.WriteLine("vowel");
                                    }
                                    else
                                    {
                                        if (ch == 'I')
                                        {
                                            Console.WriteLine("vowel");
                                        }
                                        else
                                        {
                                            if (ch == 'O')
                                            {
                                                Console.WriteLine("vowel");
                                            }
                                            else
                                            {
                                                if (ch == 'U')
                                                {
                                                    Console.WriteLine("vowel");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Consonant");
                                                }
                                                Console.ReadLine();

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
