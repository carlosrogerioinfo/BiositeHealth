using Biosite.Domain.Problem.Events.ProblemEvents;
using DomainNotificationHelper;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Handlers.Problem
{
    public class OnDiseasePrescriptionRegisteredHandler : IHandler<OnDiseasePrescriptionRegisteredEvent>
    {
        public void Dispose()
        {
            // 
        }

        public void Handle(OnDiseasePrescriptionRegisteredEvent args)
        {
            throw new NotImplementedException();
        }

        public bool HasNotifications()
        {
            return false;
        }

        public IEnumerable<OnDiseasePrescriptionRegisteredEvent> Notify()
        {
            return null;
        }


    }
}
