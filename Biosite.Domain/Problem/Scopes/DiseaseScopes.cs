using Biosite.Domain.Problem.Entities;
using DomainNotificationHelper.Validation;

namespace Biosite.Domain.Problem.Scopes
{
    public static class DiseaseScopes
    {
        public static bool RegisterScopeIsValid(this Disease disease)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(disease, "Nenhuma doença informada!")
                );
        }


    }
}
