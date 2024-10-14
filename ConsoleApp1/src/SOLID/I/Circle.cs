namespace ConsoleApp1.src.SOLID.I
{
    public class Circle : IShape2D
    {
        public double Radius {get; set;}
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}