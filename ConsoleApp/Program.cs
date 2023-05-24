using MayBLib;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = TestClass.DLL_Sum(2d, 4d);

            Console.WriteLine("The sum is " + sum.ToString());
        }
    }
}
