using Biosite.Domain.ExamName.Entities;
using Biosite.Domain.ExamName.Repositories;
using Biosite.Domain.ExamName.Specs;
using Biosite.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biosite.Infra.Repositories.ExamName
{
    public class ExamRepository : IExamRepository
    {
        private readonly BiositeDataContext _context;

        public ExamRepository(BiositeDataContext context)
        {
            _context = context;
        }

        public void Save(Exam obj)
        {
            _context.Exams.Add(obj);
        }

        public void Update(Exam obj)
        {
            _context.Entry<Exam>(obj).State = System.Data.Entity.EntityState.Modified;
        }

        public ICollection<Exam> GetAll()
        {
            return _context.Exams.ToList();
        }

        public Exam GetById(Guid id)
        {
            return _context
                .Exams
                .Where(ExamSpecs.GetById(id))
                .FirstOrDefault();
        }

        public Exam GetByExamCode(int examCode)
        {
            return _context
                .Exams
                .Where(ExamSpecs.GetByExamCode(examCode))
                .FirstOrDefault();
        }

        public Exam GetByExamName(string examName)
        {
            return _context
                .Exams
                .Where(ExamSpecs.GetByExamName(examName))
                .FirstOrDefault();
        }

    }
}
