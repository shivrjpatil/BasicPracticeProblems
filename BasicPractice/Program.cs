using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{           
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to choose the program");
            Console.WriteLine("1.Prime Number of a given range \n2.Factorial of given number \n3.Fibonacci series of given number ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   PrimeNumber prime=new PrimeNumber();
                   prime.Prime();
                   Console.ReadLine();
                   break;
                case 2:
                   Factorial fact=new Factorial();
                   fact.Fact(6);
                   Console.ReadLine();
                   break;
                case 3:    
                   Fibonacci fibonacci = new Fibonacci();
                   fibonacci.Fibseries(10);
                   Console.ReadLine();
                   break;

                

            }

        }
    }
}
