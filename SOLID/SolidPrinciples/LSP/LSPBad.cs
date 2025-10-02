using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP
{
    internal class LSPBad
    {
        public class Rectangle
        {
            public virtual double Width { get; set; }
            public virtual double Height { get; set; }

            public double CalculateArea()
            {
                return Width * Height;
            }
        }
        // ❗it's bad because we enforce a square 
        // width and heighe to always be equal
        public class Square : Rectangle
        {
            public override double Width
            {
                get => base.Width;
                set => base.Width = base.Height = value;
            }

            public override double Height
            {
                get => base.Height;
                set => base.Height = base.Width = value;
            }
        }
    }
}

//*To adhere to LSP 
// * we should avoid inheritance between Rectangle and Square where 
// * their behaivors diverge
// *
// public abstract class Shape
//{
//    public abstract double CalculateArea();
//}
//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//public class Square : Shape
//{
//    public double SideLength { get; set; }
//    public override double CalculateArea()
//    {
//        return SideLength * SideLength;
//    }
//}
