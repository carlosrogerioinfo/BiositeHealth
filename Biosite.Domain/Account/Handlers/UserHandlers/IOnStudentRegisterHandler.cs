using DomainNotificationHelper;
using Biosite.Domain.Account.Events.UserEvents;

namespace Biosite.Domain.Account.Handlers.UserHandlers
{
    public interface IOnStudentRegisterHandler : IHandler<OnUserRegisteredEvent>
    {
    }
}
