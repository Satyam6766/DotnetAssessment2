using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus6PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class Dimension in separate class but within the same assembly.
            Dimension obj = new Dimension();

            // Accessible in class Program
            obj.setData(2, 1);
            obj.DisplayData();

            Console.ReadLine();
        }
    }
    internal class Dimension  //although bydefault scope of class is internal only
    {
        int height;
        int width;
        public void setData(int h,int w)
        {
            height = h;width = w;
        }
        public void DisplayData()
        {
            Console.WriteLine("Height is:"+height);
            Console.WriteLine("Width is:"+width);
        }
    }
    
}

//Now if we include this piece of code then it will give error because class declared is internal so its scope is beyond this particular namespace which holds it.
//    namespace xyz
//{

//    class text
//    {

//        // Will give an error during compilation
//        Dimension obj2 = new Dimension();
//        obj2.setData(2, 3);
//            obj2.DisplayData();
//        }
//}
