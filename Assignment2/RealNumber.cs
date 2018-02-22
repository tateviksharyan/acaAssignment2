namespace Assignment2
{
    /// <summary>
    /// The RealNumber class
    /// </summary>
    class RealNumber
    {
        /// <summary>
        /// The real number
        /// </summary>
        private double num;

        /// <summary>
        /// Creates a real number
        /// </summary>
        /// <param name="num"> The real number</param>
        public RealNumber(double num)
        {
            this.num = num;
        }

        /// <summary>
        /// Returns the real number
        /// </summary>
        /// <returns></returns>
        public double getNumber()
        {
            return this.num;
        }

        /// <summary>
        /// The + operator overloading
        /// </summary>
        /// <param name="num1"> First operand </param>
        /// <param name="num2"> Second operand </param>
        /// <returns></returns>
        public static RealNumber operator +(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num + num2.num);
        }

        /// <summary>
        /// The - operator overloading
        /// </summary>
        /// <param name="num1"> First operand </param>
        /// <param name="num2"> Second operand </param>
        /// <returns></returns>
        public static RealNumber operator -(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num - num2.num);
        }

        /// <summary>
        /// The * operator overloading
        /// </summary>
        /// <param name="num1"> First operand </param>
        /// <param name="num2"> Second operand </param>
        /// <returns></returns>
        public static RealNumber operator *(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num * num2.num);
        }

        /// <summary>
        /// The / operator overloading
        /// </summary>
        /// <param name="num1"> First operand </param>
        /// <param name="num2"> Second operand </param>
        /// <returns></returns>
        public static RealNumber operator /(RealNumber num1, RealNumber num2)
        {
            return new RealNumber(num1.num / num2.num);
        }

        /// <summary>
        /// ToString() method overriding
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return num + "";
        }
    }
}
