using Biosite.Domain.ExamName.Entities;
using Biosite.Domain.ExamName.Commands.ExamNameCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.ExamName.Services
{
    public interface IExamApplicationService
    {
        Exam Register(RegisterExamCommand command);
        Exam GetExamByExamId(Guid id);
        Exam GetExamByExamCode(int examCode);
        Exam GetExamByExamName(string examName);
        ICollection<Exam> GetAllExams();

    }
}
