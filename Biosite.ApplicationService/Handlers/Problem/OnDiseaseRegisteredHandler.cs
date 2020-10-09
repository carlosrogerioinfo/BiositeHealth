using Biosite.Domain.Problem.Events.ProblemEvents;
using DomainNotificationHelper;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Handlers.Problem
{
    public class OnDiseaseRegisteredHandler : IHandler<OnDiseaseRegisteredEvent>
    {
        public void Dispose()
        {
            // 
        }

        public void Handle(OnDiseaseRegisteredEvent args)
        {
            throw new NotImplementedException();
        }

        public bool HasNotifications()
        {
            return false;
        }

        public IEnumerable<OnDiseaseRegisteredEvent> Notify()
        {
            return null;
        }


    }
}
