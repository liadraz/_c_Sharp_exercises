using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws2___Shapes_Hierarchy
{
    public class ComplexShape
    {
        private List<Shape> compShape = new List<Shape>();

        private double totalArea { get; set; }
        private double totalPerimeter { get; set; }

        public void Add(Shape shape)
        {
            totalArea += shape.Area();
            totalPerimeter += shape.Perimeter();

            compShape.Add(shape);
        }

        public double Area()
        {
            return totalArea;
        }

        public double Perimeter()
        {
            return totalPerimeter;
        }
    }
}
