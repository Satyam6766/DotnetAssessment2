using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Method1();  //Public method ,so can be accessed anywhere.
           // obj.Method2()  //Private method ,strictly probihited.Can Only be accessed inside its own class.
          // obj.Method3()    //protected method ,Can Only be accessed inside its child class.
            Console.ReadLine();
            Class2 obj2 = new Class2();
            Console.WriteLine(obj2.getX());//Here it is protected so can only be accessed inside child class.
        }
    }
   class Class1
    {
        protected int x;

        public Class1()
        {
            x = 10;
        }
        public void Method1()
        {
            Console.WriteLine("Public Method,can be accessed anywhere");
        }
        private void Method2()
        {
            Console.WriteLine("private Method,can not be accessed outside class");
        }
       

    }
    class Class2 : Class1
    {
        
        public int getX()
        {
            return x;
        }

    }
    
}
