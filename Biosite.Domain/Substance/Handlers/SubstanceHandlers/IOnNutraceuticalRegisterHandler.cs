using Biosite.Domain.Substance.Events.NutraceuticalEvents;
using DomainNotificationHelper;

namespace Biosite.Domain.Substance.Handlers.SubstanceHandlers
{
    public interface IOnNutraceuticalRegisterHandler : IHandler<OnNutraceuticalRegisteredEvent>
    {
    }
}
