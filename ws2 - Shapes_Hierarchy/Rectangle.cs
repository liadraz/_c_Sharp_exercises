using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws2___Shapes_Hierarchy
{
    public class Rectangle : Shape
    {
        double Width { get; set; }
        double Length { get; set; }

        static Rectangle()
        {
            IsRecInitalized();
        }
        static public void IsRecInitalized()
        {
            Console.WriteLine("Rectangle class initialized");
        }

        public Rectangle(double width = 1.0, double length = 1.0)
        {
            Width = width;
            Length = length;
        }

        public Rectangle(double width, double length, string color, bool isFilled) : base(color, isFilled)
        {
            Width = width;
            Length = length;
        }

        public override double Area()
        {
            return (Width * Length);
        }

        public override double Perimeter()
        {
            return ((2 * Width) + (2 * Length)); 
        }

        public override string ToString()
        {
            return $"A Rectangle with width {Width} and length {Length}, which is derived class of {base.ToString()}";
        }

    }
}
