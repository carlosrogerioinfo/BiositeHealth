using DomainNotificationHelper.Events.Contracts;
using Biosite.Domain.Formulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Formulation.Events.FormulationEvents
{
    public class OnPrescriptionDetailRegisteredEvent : IDomainEvent
    {
        public OnPrescriptionDetailRegisteredEvent(PrescriptionDetail prescriptionDetail)
        {
            Date = DateTime.Now;
            PrescriptionDetail = prescriptionDetail;
        }

        public PrescriptionDetail PrescriptionDetail { get; set; }
        public DateTime Date { get; set; }
    }
}
