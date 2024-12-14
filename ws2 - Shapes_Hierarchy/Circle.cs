using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ws2_ShapesHierarchy
{
    public class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double radius = 1.0)
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool isFilled) : base(color, isFilled)
        {
            Radius = radius;
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
