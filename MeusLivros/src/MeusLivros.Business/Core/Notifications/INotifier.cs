using System.Collections.Generic;

namespace MeusLivros.Business.Core.Notifications
{
    public interface INotifier
    {
        bool HasNotification();

        List<Notification> GetNotifications();

        void Handle(Notification notifications);
    }
}
