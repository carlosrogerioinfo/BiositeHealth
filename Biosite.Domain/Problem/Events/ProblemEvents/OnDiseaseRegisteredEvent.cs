using Biosite.Domain.Problem.Entities;
using DomainNotificationHelper.Events.Contracts;
using System;

namespace Biosite.Domain.Problem.Events.ProblemEvents
{
    public class OnDiseaseRegisteredEvent : IDomainEvent
    {
        public OnDiseaseRegisteredEvent(Disease disease)
        {
            Date = DateTime.Now;
            Disease = disease;
        }

        public Disease Disease { get; set; }
        public DateTime Date { get; set; }
    }
}
