using Biosite.Domain.Formulation.Events.FormulationEvents;
using DomainNotificationHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Formulation.Handlers.FormulationHandlers
{
    public interface IOnPrescriptionDetailRegisterHandler : IHandler<OnPrescriptionDetailRegisteredEvent>
    {
    }
}
