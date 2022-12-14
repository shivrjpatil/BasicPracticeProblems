using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class Fibonacci
    {
        public void Fibseries(int num)
        {
            int a = 0;
            int b = 1;
            int c=0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < num; i++)   
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);

            }

        }
    }
}
