using System;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    static public class toTest
    {
        public static long Factorial(long n)
        {
            if (n < 0 || n > 19)
            {
                throw new ArgumentException("Аргумент должен быть положительным числом", nameof(n));
            }
            long answer = 1;
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }

        private static void NormalizeAngle(ref double angle)
        {
            double twoPi = 2.0 * Math.PI;
            angle %= twoPi;
            if (angle < 0)
            {
                angle += twoPi;
            }
        }


        public static double mySin(double x)
        {
            NormalizeAngle(ref x);
            int n = 100;
            double answer = 0;
            for(int i = 0; i < n; i++)
            {
                try
                {
                    int exponent = 2 * i + 1;
                    answer += Math.Pow(-1, i) * Math.Pow(x, exponent) / Factorial(exponent);
                }
                catch (Exception e)
                {
                    break;
                }
            }
            answer = Math.Round(answer, 3);
            return answer;
        }

        public static double myCos(double x)
        {
            NormalizeAngle(ref x);
            int n = 100;
            double answer = 0;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    int exponent = 2 * i;
                    answer += Math.Pow(-1, i) * Math.Pow(x, exponent) / Factorial(exponent);
                }
                catch (Exception e)
                {
                    break;
                }
            }
            answer = Math.Round(answer, 3);
            return answer;
        }

        public static double myLn(double x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("Аргумент должен быть положительным числом", nameof(x));
            }

            int n = 100;
            double answer = 0;
            for (int i = 1; i <= n; i++)
            {
                try
                {
                    int exponent = i;
                    answer += Math.Pow(-1, i - 1) * Math.Pow(x - 1, exponent) / exponent;
                }
                catch (Exception e)
                {
                    break;
                }
            }
            answer = Math.Round(answer, 3);
            return answer;
        }

        public static double myFunction(double x)
        {
            double answer = 0;
            if (x >= 0)
            {
                answer = myLn(x) * myCos(x);
            }
            else
            {
                answer = Math.Abs(mySin(x) - myCos(x)) / (myLn(Math.Abs(x)) + 1);
            }
            return answer;
        }

        static void Main(string[] args)
        {
        }
    }
}
