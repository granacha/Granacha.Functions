using System;
using System.Collections.Generic;

namespace Granacha.Functions
{
    public class Fibonacci
    {
        public static int Calculate (int zeroBasedPosition)
        {
            int fib(int n)
            {
                if (n == 0 || n == 1) return n;

                return fib(n - 1) + fib(n - 2);
            }

            return fib(zeroBasedPosition);
        }

        public static List<int> GetFirstNElements(int elements)
        {
            return GenerateFibonacciSequence(elements);
        }

        private static List<int> GenerateFibonacciSequence(int size)
        {
            var elements = new List<int>();

            for(int i = 0; i < size; i++)
            {
                if(i == 0)
                {
                    elements.Add(0);
                }
                else if(i == 1)
                {
                    elements.Add(1);
                }
                else
                {
                    elements.Add(elements[i - 1] + elements[i - 2]);
                }
            }

            return elements;
        }
    }
}
