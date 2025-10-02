using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* objects of a superclass
should be replaceable with objects of a subclass without
altering the correctness of the program
*/
namespace SolidPrinciples.LSP
{
    internal class LSPExample
    {
        public abstract class Shape
        {
            public abstract double CalculateArea();
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}
