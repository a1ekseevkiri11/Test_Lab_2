using ConsoleApp2;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private double rounding = 0.01;

        [TestCase(1, 1)]
        [TestCase(3, 6)]
        [TestCase(0, 1)]
        [TestCase(5, 120)]
        [TestCase(7, 5040)]
        [TestCase(10, 3628800)]
        [TestCase(19, 121645100408832000)]
        public void Factorial(long n, long res)
        {
            Assert.AreEqual(res, toTest.Factorial(n));
        }


        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(20)]
        public void FactorialInvalidInput(long n)
        {
            Assert.Throws<ArgumentException>(() => toTest.Factorial(n));
        }




        [TestCase(0)]
        [TestCase(Math.PI / 6)]
        [TestCase(Math.PI / 4)]
        [TestCase(Math.PI / 3)]
        [TestCase(Math.PI / 2)]
        [TestCase(Math.PI)]
        [TestCase(3 * Math.PI / 2)]
        [TestCase(-Math.PI / 4)]
        [TestCase(-Math.PI / 3)]
        [TestCase(-Math.PI / 2)]
        public void mySin(double angle)
        {
            double expected = Math.Sin(angle);
            double result = toTest.mySin(angle);
            Assert.AreEqual(expected, result, rounding);
        }


        [TestCase(0)]
        [TestCase(Math.PI / 6)]
        [TestCase(Math.PI / 4)]
        [TestCase(Math.PI / 3)]
        [TestCase(Math.PI / 2)]
        [TestCase(Math.PI)]
        [TestCase(3 * Math.PI / 2)]
        [TestCase(-Math.PI / 4)]
        [TestCase(-Math.PI / 3)]
        [TestCase(-Math.PI / 2)]
        public void myCos(double angle)
        {
            double expected = Math.Cos(angle);
            double result = toTest.myCos(angle);
            Assert.AreEqual(expected, result, rounding);
        }

        [TestCase(1)] 
        [TestCase(2)] 
        [TestCase(0.5)] 
        public void myLn(double x)
        {
            double expected = Math.Log(x);
            double result = toTest.myLn(x);
            Assert.AreEqual(expected, result, rounding); // Устанавливаем допустимую погрешность
        }

        [TestCase(-1)]
        public void myLn_InvalidArgument(double x)
        {
            
            Assert.Throws<ArgumentException>(() => toTest.myLn(x));
        }


        [TestCase(1, 0.0)]
        [TestCase(-1, 1.382)]
        [TestCase(-0.5, 4.422)]
        public void MyFunction(double x, double expected)
        {
            double result = toTest.myFunction(x);
            Assert.AreEqual(expected, result, rounding); // Устанавливаем допустимую погрешность
        }
    }
}