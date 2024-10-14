namespace ConsoleApp1.src.SOLID.O
{
    public class Circle : Shape
    {
        public double Radius {get; set;}
        public override double calculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}