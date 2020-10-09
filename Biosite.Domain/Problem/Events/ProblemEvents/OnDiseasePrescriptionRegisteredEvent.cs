using Biosite.Domain.Problem.Entities;
using DomainNotificationHelper.Events.Contracts;
using System;

namespace Biosite.Domain.Problem.Events.ProblemEvents
{
    public class OnDiseasePrescriptionRegisteredEvent : IDomainEvent
    {
        public OnDiseasePrescriptionRegisteredEvent(DiseasePrescription diseasePrescription)
        {
            Date = DateTime.Now;
            DiseasePrescription = diseasePrescription;
        }

        public DiseasePrescription DiseasePrescription { get; set; }
        public DateTime Date { get; set; }
    }
}
