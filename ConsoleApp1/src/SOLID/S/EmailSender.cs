namespace ConsoleApp1.src.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email, string message){
            System.Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}