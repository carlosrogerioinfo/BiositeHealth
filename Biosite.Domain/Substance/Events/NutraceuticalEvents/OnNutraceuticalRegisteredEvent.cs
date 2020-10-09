using Biosite.Domain.Substance.Entities;
using DomainNotificationHelper.Events.Contracts;
using System;

namespace Biosite.Domain.Substance.Events.NutraceuticalEvents
{
    public class OnNutraceuticalRegisteredEvent : IDomainEvent
    {
        public OnNutraceuticalRegisteredEvent(Nutraceutical nutraceutical)
        {
            Date = DateTime.Now;
            Nutraceutical = nutraceutical;
        }

        public Nutraceutical Nutraceutical { get; set; }
        public DateTime Date { get; set; }
    }
}
