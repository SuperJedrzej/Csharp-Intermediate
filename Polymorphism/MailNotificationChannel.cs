namespace Polymorphism
{
    public class MailNotificationChannel : INoticifationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending Mail");
        }
    }
}
