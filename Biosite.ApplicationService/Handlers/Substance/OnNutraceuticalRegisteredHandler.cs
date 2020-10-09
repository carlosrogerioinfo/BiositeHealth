using Biosite.Domain.Substance.Events.NutraceuticalEvents;
using DomainNotificationHelper;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Handlers.Substance
{
    public class OnNutraceuticalRegisteredHandler : IHandler<OnNutraceuticalRegisteredEvent>
    {
        public void Dispose()
        {
            // 
        }

        public void Handle(OnNutraceuticalRegisteredEvent args)
        {
            throw new NotImplementedException();
        }

        public bool HasNotifications()
        {
            return false;
        }

        public IEnumerable<OnNutraceuticalRegisteredEvent> Notify()
        {
            return null;
        }


    }
}
