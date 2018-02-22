using System;

namespace Assignment2
{
    class ComplexNumber
    {
        // Real part of complex number
        private RealNumber real;
        // Imaginary part of complex number
        private RealNumber imaginary;

        /// <summary>
        /// Creates a complex number
        /// </summary>
        /// <param name="real"> Real part </param>
        /// <param name="imaginary"> Imaginary part </param>
        public ComplexNumber(RealNumber real, RealNumber imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        /// <summary>
        /// Complex numbers addition
        /// </summary>
        /// <param name="comp"> Operand </param>
        /// <returns> Sum of complex numbers </returns>
        public ComplexNumber addition(ComplexNumber comp)
        {
            return new ComplexNumber(this.real + comp.real, this.imaginary + comp.imaginary);
        }

        /// <summary>
        /// Complex numbers subtraction
        /// </summary>
        /// <param name="comp"> Operand </param>
        /// <returns> Subtraction of complex numbers </returns>
        public ComplexNumber subtraction(ComplexNumber comp)
        {
            return new ComplexNumber(this.real - comp.real, this.imaginary - comp.imaginary);
        }

        /// <summary>
        /// Complex numbers multiplikation
        /// </summary>
        /// <param name="comp"> Operand </param>
        /// <returns> Multiplication of complex numbers </returns>
        public ComplexNumber multiplication(ComplexNumber comp)
        {
            return new ComplexNumber(this.real * comp.real - this.imaginary * comp.imaginary,
                this.imaginary * comp.real + this.real * comp.imaginary);
        }

        /// <summary>
        /// Complex numbers division
        /// </summary>
        /// <param name="comp"> Operand </param>
        /// <returns> Division of complex numbers </returns>
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

        /// <summary>
        /// The absolute value of complex number
        /// </summary>
        /// <returns> the absolute value </returns>
        public RealNumber absValue()
        {
            return new RealNumber(Math.Sqrt((this.real * this.real + this.imaginary * this.imaginary).getNumber()));
        }

        /// <summary>
        /// The Argument of complex number
        /// </summary>
        /// <returns> the argument </returns>
        public double argument()
        {
            if(this.real.getNumber() == 0)
            {
                return Math.Acos(0);
            }

            return Math.Atan((this.imaginary / this.real).getNumber());
        }

        /// <summary>
        /// ToString() method overriding
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
}
