using Biosite.Domain.ExamName.Events.ExamNameEvents;
using DomainNotificationHelper;

namespace Biosite.Domain.ExamName.Handlers.ExamNameHandlers
{
    public interface IOnExamRegisterHandler : IHandler<OnExamRegisteredEvent>
    {
    }
}
