namespace ws2_ShapesHierarchy
{
    public class ShapesHierarchy
    {
        public static void Main()
        {
            ComplexShape shapes = new ComplexShape();

            shapes.Add(new Circle());
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            Console.WriteLine($"{shapes.Area()}");

        }
    }
}