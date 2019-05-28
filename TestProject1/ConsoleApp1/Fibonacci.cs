using System;
using System.Net.NetworkInformation;
using System.Numerics;

namespace ConsoleApp1
{
    public class Fibonacci
    {
        public static void Main()
        {
            Console.WriteLine("This is main function");
        }
        public static BigInteger Print(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            
            return Print(n - 1) + Print(n - 2);
        }
    }
}