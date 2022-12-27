using MeusLivros.Business.Core.Notifications;
using System.Web.Mvc;

namespace MeusLivros.AppMvc.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotifier _notifier;

        public BaseController(INotifier notifier) => _notifier = notifier;

        protected bool IsValidOperation()
        {
            if (!_notifier.HasNotification()) return true;

            var notifications = _notifier.GetNotifications();
            notifications.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Message));
            return false;
        }
    }
}