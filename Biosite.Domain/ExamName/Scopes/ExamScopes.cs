using Biosite.Domain.ExamName.Entities;
using DomainNotificationHelper.Validation;

namespace Biosite.Domain.ExamName.Scopes
{
    public static class ExamScopes
    {
        public static bool RegisterScopeIsValid(this Exam exam)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(exam, "Nenhum nome informado!")
                );
        }


    }
}
