using FluentValidation;
using FluentValidation.Results;
using MeusLivros.Business.Core.Models;
using MeusLivros.Business.Core.Notifications;

namespace MeusLivros.Business.Core.Services
{
    public abstract class BaseService
    {
        private readonly INotifier _notifier;

        public BaseService(INotifier notifier) => _notifier = notifier;

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message) 
            => _notifier.Handle(new Notifications.Notifications(message));

        protected bool ExecuteValidations<TV, TE>(TV validation, TE entity) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validation.Validate(entity);

            if (validator.IsValid) return true;

            Notify(validator);

            return false;
        }
    }
}