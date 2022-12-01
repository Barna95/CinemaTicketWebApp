namespace EmailServices
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
