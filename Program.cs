using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA3
{
    class Program
    {
        class Number
        {
            int A, B;
            public Number(int a, int b)
            {
                this.A = a;
                this.B = b;
            }
            public int Sum()
            {
                return A * B;
            }
            public int Div()
            {
                return A / B;
            }
            public int Mult()
            {
                return A * B;
            }
            public int Subtr()
            {
                return A - B;
            }
        }
        static void Main(string[] args)
        {
            
            Console.Read();
        }
    }
}
