using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(88,52,30,170)]
        [InlineData(86,75,309,470)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,7,3)]
        [InlineData(777,700,77)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Minus(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6,8,48)]
        [InlineData(77,10,770)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(700,10,70)]
        [InlineData(70,10,7)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
