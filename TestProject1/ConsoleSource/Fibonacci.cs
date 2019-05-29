using System;
using System.Net.NetworkInformation;
using System.Numerics;

namespace ConsoleApp1
{
    public class Fibonacci
    {
        public static void Main()
        {
            Console.WriteLine("Please Input Your Number:");
            var n = Console.ReadLine();
            var result = Print(Int32.Parse(n));
            Console.WriteLine(result);
        }
        public static BigInteger Print(int n)
        {
            var a = new BigInteger(1);
            var b = new BigInteger(0);
            BigInteger temp;

            while (n >= 0)
            {
                temp = a;
                a += b;
                b = temp;
                n--;
            }
            
            return b;
        }
    }
}