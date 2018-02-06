using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class RealNumber
    {
        private double num;

        public RealNumber(double num)
        {
            this.num = num;
        }

        public double getNumber()
        {
            return this.num;
        }

        public static RealNumber operator +(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num + num2.num);
        }
        public static RealNumber operator -(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num - num2.num);
        }

        public static RealNumber operator *(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num * num2.num);
        }

        public static RealNumber operator /(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num / num2.num);
        }

        public override string ToString()
        {
            return num + "";
        }

    }
}
