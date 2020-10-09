using Biosite.Domain.Problem.Events.ProblemEvents;
using DomainNotificationHelper;

namespace Biosite.Domain.Problem.Handlers.ProblemHandlers
{
    public interface IOnDiseaseRegisterHandler : IHandler<OnDiseaseRegisteredEvent>
    {
    }
}
