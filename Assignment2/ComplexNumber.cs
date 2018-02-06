using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ComplexNumber
    {
        private RealNumber real;
        private RealNumber imaginary;

        public ComplexNumber(RealNumber real, RealNumber imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public ComplexNumber addition(ComplexNumber comp)
        {
            return new ComplexNumber(this.real + comp.real, this.imaginary + comp.imaginary);
        }
        public ComplexNumber subtraction(ComplexNumber comp)
        {
            return new ComplexNumber(this.real - comp.real, this.imaginary - comp.imaginary);
        }
        public ComplexNumber multiplication(ComplexNumber comp)
        {
            return new ComplexNumber(this.real * comp.real - this.imaginary * comp.imaginary,
                this.imaginary * comp.real + this.real * comp.imaginary);
        }

        public ComplexNumber division(ComplexNumber comp)
        {
            if(comp.real.getNumber() == 0 && comp.imaginary.getNumber() == 0)
            {
                throw new Exception("Can not divide to 0!!");
            }

            return new ComplexNumber((this.real * comp.real + this.imaginary * comp.imaginary) / 
                (comp.real * comp.real + comp.imaginary * comp.imaginary), 
                (this.imaginary * comp.real - this.real * comp.imaginary) /
                (comp.real * comp.real + comp.imaginary * comp.imaginary));
        }

        public RealNumber absValue()
        {
            return new RealNumber(Math.Sqrt((this.real * this.real + this.imaginary * this.imaginary).getNumber()));
        }

        public double argument()
        {
            if(this.real.getNumber() == 0)
            {
                return Math.Acos(0);
            }

            return Math.Atan((this.imaginary / this.real).getNumber());
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
}
