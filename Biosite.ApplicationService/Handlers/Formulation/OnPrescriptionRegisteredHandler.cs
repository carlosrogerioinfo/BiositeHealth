using DomainNotificationHelper;
using Biosite.ApplicationService.Services.Common;
using Biosite.Domain.Account.Events.UserEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biosite.Domain.Formulation.Events.FormulationEvents;

namespace Biosite.ApplicationService.Handlers.Formulation
{
    public class OnPrescriptionRegisteredHandler : IHandler<OnPrescriptionRegisteredEvent>
    {
        public void Dispose()
        {
            // 
        }

        public void Handle(OnPrescriptionRegisteredEvent args)
        {
            throw new NotImplementedException();
        }

        public bool HasNotifications()
        {
            return false;
        }

        public IEnumerable<OnPrescriptionRegisteredEvent> Notify()
        {
            return null;
        }


    }
}
