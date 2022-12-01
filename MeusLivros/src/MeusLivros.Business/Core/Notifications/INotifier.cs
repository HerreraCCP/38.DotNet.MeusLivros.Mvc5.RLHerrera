using System.Collections.Generic;

namespace MeusLivros.Business.Core.Notifications
{
    public interface INotifier
    {
        bool HasNotifications();

        List<Notifications> GetNotifications();

        void Handle(Notifications notifications);
    }
}
