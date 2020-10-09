using Biosite.Domain.ExamName.Entities;
using DomainNotificationHelper.Events.Contracts;
using System;

namespace Biosite.Domain.ExamName.Events.ExamNameEvents
{
    public class OnExamRegisteredEvent : IDomainEvent
    {
        public OnExamRegisteredEvent(Exam exam)
        {
            Date = DateTime.Now;
            Exam = exam;
        }

        public Exam Exam { get; set; }
        public DateTime Date { get; set; }
    }
}
