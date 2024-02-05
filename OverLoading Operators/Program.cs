using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* + - * /
              == =! < >  <= >=
             true false  while(true)
            &&(ve) ||(veya) ?? ? += -= *= /=  */

            MyClass x = new MyClass{X = 10 };
            MyClass y = new MyClass {X =7 };
            MyClass z = x + y;  
            Console.WriteLine(z.X);
            Console.ReadLine();

        }
    }
}
