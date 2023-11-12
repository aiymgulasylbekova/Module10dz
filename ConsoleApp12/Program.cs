using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    public interface ICalculatable
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    public class Calculator : ICalculatable
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN; // NaN (Not a Number) to represent an undefined result
            }
        }
    }

    class Program
    {
        static void Main()
        {
            AdvancedCalculator calculator = new AdvancedCalculator();

            // Примеры использования базовых операций
            calculator.Add(5, 3);
            calculator.Subtract(5, 3);
            calculator.Multiply(5, 3);
            calculator.Divide(5, 3);

            // Попытка деления на ноль
            calculator.Divide(5, 0);

            // Примеры использования дополнительных операций
            calculator.Power(2, 3);
            calculator.SquareRoot(25);

            Console.ReadLine();
        }
    }

}
