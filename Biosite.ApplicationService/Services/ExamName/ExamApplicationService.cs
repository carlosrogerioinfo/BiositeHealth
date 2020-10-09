using Biosite.Domain.ExamName.Commands.ExamNameCommands;
using Biosite.Domain.ExamName.Entities;
using Biosite.Domain.ExamName.Events.ExamNameEvents;
using Biosite.Domain.ExamName.Repositories;
using Biosite.Domain.ExamName.Services;
using Biosite.Infra.Transaction;
using DomainNotificationHelper.Events;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Services.ExamName
{
    public class ExamApplicationService : ApplicationService, IExamApplicationService
    {
        private readonly IExamRepository _repository;

        public ExamApplicationService(IExamRepository repository, IUnitOfWork uow)
            : base(uow)
        {
            _repository = repository;
        }

        public Exam Register(RegisterExamCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Exam(command.ExamCode, command.ExamName, command.ExamUnit, command.BiologicalValue, command.ReferenceMinValue, command.ReferenceMaxValue, command.UseQuartil);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Save(domain);

            // Chama o commit
            if(Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnExamRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public ICollection<Exam> GetAllExams()
        {
            return _repository.GetAll();
        }

        public Exam GetExamByExamId(Guid id)
        {
            return _repository.GetById(id);
        }

        public Exam GetExamByExamName(string examName)
        {
            return _repository.GetByExamName(examName);
        }

        public Exam GetExamByExamCode(int examCode)
        {
            return _repository.GetByExamCode(examCode);
        }

    }
}