using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            if (a < 10)
            {
                return a + b;
            }
            else
            {
                return a - 10 + b;
            }
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            if (a < 10)
            {
                return a * b;
            }
            else
            {
                return (a - 10) * b;
            }
        }

        public int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new Exception("denominator is zero");
            }
            
            return a / b;
        }

        public string Hello(string name)
        {
            return "Hello " + name + "!";
        }

        public int SquareRoot(int a)
        {
            return a;
        }

        public int Modulo(int a, int b)
        {
            return a % b;
        }

        public int Square(int a)
        {
            return a*a;
        }
    }
}
