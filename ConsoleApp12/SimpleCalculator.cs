using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    public class SimpleCalculator : ICalculatable
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            PrintResult("Addition", a, b, result);
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            PrintResult("Subtraction", a, b, result);
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            PrintResult("Multiplication", a, b, result);
            return result;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                double result = a / b;
                PrintResult("Division", a, b, result);
                return result;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN; // NaN (Not a Number) to represent an undefined result
            }
        }

        private void PrintResult(string operation, double a, double b, double result)
        {
            Console.WriteLine($"{operation}: {a} {GetOperationSymbol(operation)} {b} = {result}");
        }

        private string GetOperationSymbol(string operation)
        {
            switch (operation)
            {
                case "Addition":
                    return "+";
                case "Subtraction":
                    return "-";
                case "Multiplication":
                    return "*";
                case "Division":
                    return "/";
                default:
                    return "";
            }
        }
    }

    

}
