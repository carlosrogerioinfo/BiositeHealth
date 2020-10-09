using Biosite.Domain.ExamName.Entities;
using System;
using System.Linq.Expressions;

namespace Biosite.Domain.ExamName.Specs
{
    public static class ExamSpecs
    {
        public static Expression<Func<Exam, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Exam, bool>> GetByExamCode(int examCode)
        {
            return x => x.ExamCode == examCode;
        }

        public static Expression<Func<Exam, bool>> GetByExamName(string examName)
        {
            return x => x.ExamName == examName;
        }
    }
}
