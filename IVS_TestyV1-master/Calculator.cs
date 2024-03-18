using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace IVS_TestyV1
{
    public class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException("Can't divide by zero");
            }
        }

        public double MultSum(double a, double b, double c, double d, double e)
        {
            return a + b - c * d / e;
        }

        public double Fact(double a, double b)
        {
            while (b != 1)
            {
                b--;
                a = a * b;
            }
            return a;
        }

        public double Exponent(double a, int b)
        {
            double aBase = a;
            while (b != 1)
            {
                a = a * aBase;
                b--;
            }
            return a;
        }

        public double Root(double x, int n)
        {
            if (n == 0)
            {
                throw new ArgumentException("The root cannot be zero.");
            }
            if (x < 0 && n % 2 == 0)
            {
                throw new ArgumentException("Cannot calculate the even root of a negative number.");
            }
            if (x < 0 && n % 1 != 0)
            {
                throw new ArgumentException("Cannot calculate the non-integer root of a negative number.");
            }
            return Math.Pow(x, 1.0 / n);
        }


    }

}
