namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Rectangle(3,4),
                new Circle(7),
                new Circle(10),
                new Rectangle(11,12),
            };
            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Area());
                Console.WriteLine();
            }
        }
    }
    public interface IDrawable
    {
        public abstract void Draw();
    }

    public abstract class Shape : IDrawable
    {
        public abstract double Area();
        public abstract void Draw();

    }
    public class Circle : Shape
    {
        int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
    public class Rectangle : Shape
    {
        int Width { get; set; }
        int Height { get; set; }
        public Rectangle(int height, int width)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Height * Width;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
