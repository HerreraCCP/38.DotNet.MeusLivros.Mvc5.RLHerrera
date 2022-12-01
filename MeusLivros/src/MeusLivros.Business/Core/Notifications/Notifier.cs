using System.Collections.Generic;
using System.Linq;

namespace MeusLivros.Business.Core.Notifications
{
    public class Notifier : INotifier
    {
        private readonly List<Notifications> _notifications;

        public Notifier() 
            => _notifications = new List<Notifications>();

        public void Handle(Notifications notifications) 
            => _notifications.Add(notifications);

        public List<Notifications> GetNotifications() 
            => _notifications;

        public bool HasNotifications() 
            => _notifications.Any();
    }
}