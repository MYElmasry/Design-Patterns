namespace ConsoleApp1.src.SOLID.S
{
    public class UserService
    {
        public void Register(user user){

            // Register user logic...

            // Send Email

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email,"Welcome to our platform");

        }
    }
}