using Biosite.Domain.ExamName.Entities;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.ExamName.Repositories
{
    public interface IExamRepository
    {
        void Save(Exam exam);
        void Update(Exam exam);
        Exam GetById(Guid id);
        Exam GetByExamCode(int examCode);
        Exam GetByExamName(string examName);
        ICollection<Exam> GetAll();
    }
}
