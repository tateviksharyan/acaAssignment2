using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealNumber real1 = new RealNumber(2);
            RealNumber imaginary1 = new RealNumber(3);
            RealNumber real2 = new RealNumber(8);
            RealNumber imaginary2 = new RealNumber(6);

            ComplexNumber comp1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber comp2 = new ComplexNumber(real2, imaginary2);

            Console.WriteLine("First complex number:  {0}", comp1);
            Console.WriteLine("Second complex number: {0}", comp2);

            Console.WriteLine("Complex addition: {0}", comp1.addition(comp2));
            Console.WriteLine("Complex subtraction: {0}", comp2.subtraction(comp1));
            Console.WriteLine("Complex multiplication: {0}", comp1.multiplication(comp2));
            Console.WriteLine("Complex division: {0}", comp2.addition(comp1));
            Console.WriteLine("Complex absolute value: {0}", comp1.absValue());
            Console.WriteLine("Complex argument: {0}", comp1.argument());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
