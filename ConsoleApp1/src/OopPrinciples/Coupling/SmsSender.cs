namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        
        public void SendNotification(string message)
        {
            System.Console.WriteLine("Sms message: "+ message);
        }
    }
}