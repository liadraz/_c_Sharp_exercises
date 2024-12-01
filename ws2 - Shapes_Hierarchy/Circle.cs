using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ws2___Shapes_Hierarchy
{
    public class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double radius = 1.0)
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool isFilled)
        {
            Radius = radius;
            Color = color;
            IsFilled = isFilled;
        }

        public override double Area()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }

        public override double Perimeter()
        {
            return (2 * Math.PI * Radius);   
        }
        public override string ToString()
        {
            return $"A Circle with radius {Radius}, which is derived class of {base.ToString()}";
        }
    }
}
