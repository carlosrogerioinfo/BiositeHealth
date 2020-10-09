using Biosite.Domain.Formulation.Entities;
using DomainNotificationHelper.Validation;

namespace Biosite.Domain.Formulation.Scopes
{
    public static class PrescriptionScopes
    {
        public static bool RegisterScopeIsValid(this Prescription prescription)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(prescription, "Nenhuma formulação informada!")
                );
        }


    }
}
