using Biosite.Domain.ExamName.Events.ExamNameEvents;
using DomainNotificationHelper;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Handlers.ExamName
{
    public class OnExamRegisteredHandler : IHandler<OnExamRegisteredEvent>
    {
        public void Dispose()
        {
            // 
        }

        public void Handle(OnExamRegisteredEvent args)
        {
            throw new NotImplementedException();
        }

        public bool HasNotifications()
        {
            return false;
        }

        public IEnumerable<OnExamRegisteredEvent> Notify()
        {
            return null;
        }


    }
}
