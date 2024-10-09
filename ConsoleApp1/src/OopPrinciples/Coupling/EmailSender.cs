namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        
        public void SendNotification(string message)
        {
            System.Console.WriteLine("Sending email: "+ message);
        }
    }
}