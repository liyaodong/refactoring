using System;
using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
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
            Assert.Equal(4, Fibonacci.Print(5));
            Assert.Equal(5, Fibonacci.Print(8));
            Assert.Equal(10, Fibonacci.Print(89));
        }
    }
}