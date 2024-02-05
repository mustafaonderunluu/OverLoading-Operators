using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Operators
{
    internal class MyClass
    {
        public int X { get; set; }
        public static MyClass operator +(MyClass left, MyClass right) {


            return new MyClass { X = left.X + right.X };
        }
    }
}
