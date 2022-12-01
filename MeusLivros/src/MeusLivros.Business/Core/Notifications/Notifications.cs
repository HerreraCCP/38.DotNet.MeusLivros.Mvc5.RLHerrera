namespace MeusLivros.Business.Core.Notifications
{
    public class Notifications
    {
        public Notifications(string message) => Message = message;

        public string Message { get; set; }
    }
}