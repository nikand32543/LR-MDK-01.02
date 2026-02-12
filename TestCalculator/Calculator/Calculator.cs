using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculatorr
    {
        public double Summ(double x, double y)
            { return x + y; }
        public double Subtraction(double x,double y)
            { return x - y; }
        public double Multiplication(double x,double y)
            { return x * y; }
        public double Divide(double x,double y)
        {
            if(y == 0)
            {  return 0; }
            return x / y;
        }
        

    }
}
