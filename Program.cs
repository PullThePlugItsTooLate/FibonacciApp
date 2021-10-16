using System;
using System.Collections.Generic;

namespace FibonacciApp
{
    //STUDENT NAME: SUVASHIN MOODLIAR
    //STUDENT NUMBER: 19003564
    //MODULE: PROG
    //TASK: ICE - Create an app to calculate the nth term in the fibonacci sequence

    class Program
    {
        //----------------------------------------------CODE-ATTRIBUTION------------------------------------------
        //URL: https://www.davidhayden.me/blog/recursive-fibonacci-and-memoization-in-csharp
        //DATE ACCESSED: 21/08/2021
        //DATE PUBLISHED: NULL
        //AUTHOR: David Hayden


        static Dictionary<int, long> _memo = new Dictionary<int, long>(){ { 0, 0 }, { 1, 1 } }; //Dictionary used for caching

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to generate Fib without memoization or press 0 to generate Fib with memoization");//
            int option = Convert.ToInt32(Console.ReadLine()); //User input, chosen option either uses or doesn't use memoization
            if (option == 1)
            {
                for (int i = 0; i < 75; i++)
                {
                    Console.WriteLine($"Fib({i}) = {Fib(i)}");
                }
            }
            else 
            {
                if (option == 0)
                {
                    for (int i = 0; i < 75; i++)
                    {
                        Console.WriteLine($"FibM({i}) = {FibM(i)}");
                    }
                }
                
            }
        }

        static long Fib(int n) //Doesn't use memoization 
        {
            if (n < 2) return n;

            return Fib(n - 1) + Fib(n - 2);
        }

        static long FibM(int n) //Does use memoization via dictionary that was instantiated above
        {
            if (_memo.ContainsKey(n))
                return _memo[n];

            var value = FibM(n - 1) + FibM(n - 2);

            _memo[n] = value;

            return value;
        }

        //-----------------------------------------CODE-ATTRIBUTION-ENDS-HERE--------------------------------------
    }
}
