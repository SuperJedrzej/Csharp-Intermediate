namespace Polymorphism
{
    public class SmsNotificationChannel : INoticifationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS");
        }
    }
}
