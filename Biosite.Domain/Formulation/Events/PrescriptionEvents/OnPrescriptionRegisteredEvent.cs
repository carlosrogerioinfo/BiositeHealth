using DomainNotificationHelper.Events.Contracts;
using Biosite.Domain.Formulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Formulation.Events.FormulationEvents
{
    public class OnPrescriptionRegisteredEvent : IDomainEvent
    {
        public OnPrescriptionRegisteredEvent(Prescription prescription)
        {
            Date = DateTime.Now;
            Prescription = prescription;
        }

        public Prescription Prescription { get; set; }
        public DateTime Date { get; set; }
    }
}
