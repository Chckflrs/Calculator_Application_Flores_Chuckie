using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Application
{
    public delegate T Formula<T>(T arg, T args);
    internal class CalculatorClass
    {
        public Formula<string> formula;
        public Double GetSum(double num1, double num2) { 
            return num1 + num2;
        }
        public Double GetDifference(double num1, double num2) { 
            return num1 - num2;
        }
        public Double GetProduct(double num1, double num2) { 
            return num1 * num2;
        }
        public Double GetQuotient(double num1, double num2) {
            return num1 / num2;
        }
        public event Formula<double> CalculateEvent { 
            add { Console.WriteLine("Added the delegate"); } remove { Console.WriteLine("Remove the Delegate"); }  
        }
    }
}
