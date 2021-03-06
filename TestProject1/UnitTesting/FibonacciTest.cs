using System.Numerics;
using ConsoleApp1;
using Xunit;

namespace UnitTesting
{
    public class FibonacciTest
    {
        [Fact]
        public void GivenZeroFibonacciShouldReturnOne()
        {
            var output = Fibonacci.Print(0);
            Assert.Equal(1, output);
        }
        
        [Fact]
        public void GivenOneFibonacciShouldReturnOne()
        {
            var output = Fibonacci.Print(1);
            Assert.Equal(1, output);
        }

        [Fact]
        public void GivenLargeTwoFibonacciShouldReturnCorrect()
        {
            Assert.Equal(2, Fibonacci.Print(2));
            Assert.Equal(3, Fibonacci.Print(3));
            Assert.Equal(5, Fibonacci.Print(4));
            Assert.Equal(8, Fibonacci.Print(5));
            Assert.Equal(89, Fibonacci.Print(10));
        }

        [Fact]
        public void GivenVeryLargeNumberFibonacciShouldWorkPerfect()
        {
            Assert.Equal(BigInteger.Parse("8670007398507948658051921"), Fibonacci.Print(120));
        }
    }
}