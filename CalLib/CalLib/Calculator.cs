using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLib
{
    public class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

       /* public Calculator()
        {

        }
        public Calculator(double _num1,double _num2)
        {
            num1 = _num1;
            num2 = _num2;
        }*/

        public double Addition()
        {
            return num1 + num2;
        }

        public double Substraction()
        {
            return num1 - num2;
        }

        public double Multiplication()
        {
            return num1 * num2;
        }
        public double Divide()
        {
            return num1 / num2;
        }

    }
}
