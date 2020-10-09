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
    public class OnPrescriptionDetailRegisteredHandler : IHandler<OnPrescriptionDetailRegisteredEvent>
    {
        public void Dispose()
        {
            // 
        }

        public void Handle(OnPrescriptionDetailRegisteredEvent args)
        {
            throw new NotImplementedException();
        }

        public bool HasNotifications()
        {
            return false;
        }

        public IEnumerable<OnPrescriptionDetailRegisteredEvent> Notify()
        {
            return null;
        }


    }
}
