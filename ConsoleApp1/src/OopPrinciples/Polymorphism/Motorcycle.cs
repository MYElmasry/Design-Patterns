namespace ConsoleApp1.src.OopPrinciples.Polymorphism
{
    public class Motorcycle : Vehicle
    {
      
        public override void Start(){
            System.Console.WriteLine("Motorcycle is starting...");
        }
        public override void Stop(){
            System.Console.WriteLine("Motorcycle is stopping...");
        }

    }
}