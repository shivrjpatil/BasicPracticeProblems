using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            for (int num = 0; num <= 100; num++)
            {
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("prime numbers between 1 TO 100");
                    Console.WriteLine(num);
                }

            }
        }
    }
}
