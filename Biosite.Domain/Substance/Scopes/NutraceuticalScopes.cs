using Biosite.Domain.Substance.Entities;
using DomainNotificationHelper.Validation;

namespace Biosite.Domain.Substance.Scopes
{
    public static class NutraceuticalScopes
    {
        public static bool RegisterScopeIsValid(this Nutraceutical nutraceutical)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(nutraceutical, "Nenhuma formulação informada!")
                );
        }


    }
}
