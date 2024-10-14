namespace ConsoleApp1.src.SOLID.O
{
    public class Rectangle : Shape
    {
        public double Width {get; set;}
        public double Length {get; set;}
        public override double calculateArea()
        {
            return Width * Length;
        }
    }
}