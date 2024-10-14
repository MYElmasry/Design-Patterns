namespace ConsoleApp1.src.SOLID.D
{
    public class Car
    {
        private IEngine engine;
         
        public Car(IEngine engine){
            this.engine = engine;
        }
        public void StartCar(){
            engine.Start();
            System.Console.WriteLine("Car started");
        }
    }
}