using System.Collections.Generic;

namespace MeusLivros.Business.Core.Notificacoes
{
    public interface INotifier
    {
        bool HasNotifications();

        List<Notifications> GetNotifications();

        void Handle(Notifications notifications);
    }
}
