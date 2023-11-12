using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    public class AdvancedCalculator : SimpleCalculator
    {
        public double Power(double baseValue, double exponent)
        {
            double result = Math.Pow(baseValue, exponent);
            PrintResult("Power", baseValue, exponent, result);
            return result;
        }

        private void PrintResult(string v, double baseValue, double exponent, double result)
        {
            throw new NotImplementedException();
        }

        public double SquareRoot(double value)
        {
            if (value >= 0)
            {
                double result = Math.Sqrt(value);
                PrintResult("Square Root", value, 2, result);
                return result;
            }
            else
            {
                Console.WriteLine("Cannot calculate square root of a negative number!");
                return double.NaN; // NaN (Not a Number) to represent an undefined result
            }
        }
    }

    

}
