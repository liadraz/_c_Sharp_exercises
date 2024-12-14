using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws2_ShapesHierarchy
{
    public abstract class Shape
    {
        public string Color { get; set; } = String.Empty;
        public bool IsFilled { get; set; }

        public Shape() : this("green", true) { }

        public Shape(string color, bool isFilled)
        {
            Color = color;
            IsFilled = isFilled;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"A Shape with color of {Color} and filled {IsFilled}";
        }
    }
}
