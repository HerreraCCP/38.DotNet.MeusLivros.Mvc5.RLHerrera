namespace MeusLivros.Business.Core.Notificacoes
{
    public class Notifications
    {
        public Notifications(string message) => Message = message;

        public string Message { get; set; }
    }
}