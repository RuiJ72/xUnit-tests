using System;
using System.Collections.Generic;

namespace ProjetoDeTeste
{
    public class Calculator
    {
        private List<string> listbackground;
        public Calculator()
        {
            listbackground = new List<string>();
        }

        public double Sum(double value1, double value2)
        {
            double res = value1 + value2;
            listbackground.Insert(0, "Result: " + res);
            return res;
        }

        public double Subtraction(double value1, double value2)
        {
            double res = value1 - value2;
            listbackground.Insert(0, "Result: " + res);
            return res;
        }

        public double Multiplication(double value1, double value2)
        {
            double res = value1 * value2;
            listbackground.Insert(0, "Result: " + res);
            return res;
        }

        public double Division(double value1, double value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            double res = value1 / value2;
            listbackground.Insert(0, "Result: " + res);
            return res;
        }

        public List<string> Background()
        {
            if (listbackground.Count > 3)
                listbackground.RemoveRange(3, listbackground.Count - 3);
            return listbackground;
        }
    }
}
