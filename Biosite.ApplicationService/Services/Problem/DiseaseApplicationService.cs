using Biosite.Domain.Problem.Commands.ProblemCommands;
using Biosite.Domain.Problem.Entities;
using Biosite.Domain.Problem.Events.ProblemEvents;
using Biosite.Domain.Problem.Repositories;
using Biosite.Domain.Problem.Services;
using Biosite.Infra.Transaction;
using DomainNotificationHelper.Events;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Services.Problem
{
    public class DiseaseApplicationService : ApplicationService, IDiseaseApplicationService
    {
        private readonly IDiseaseRepository _repository;

        public DiseaseApplicationService(IDiseaseRepository repository, IUnitOfWork uow)
            : base(uow)
        {
            _repository = repository;
        }

        public Disease Register(RegisterDiseaseCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Disease(command.Name, command.CID, command.Description);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Save(domain);

            // Chama o commit
            if(Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnDiseaseRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public Disease Update(UpdateDiseaseCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Disease(command.Id, command.Name, command.CID, command.Description);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Update(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnDiseaseRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public DiseasePrescription RegisterDiseasePrescription(RegisterDiseasePrescriptionCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new DiseasePrescription(command.DiseaseId, command.PrescriptionId);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.SaveDiseasePrescription(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnDiseasePrescriptionRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public DiseasePrescription UpdateDiseasePrescription(UpdateDiseasePrescriptionCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new DiseasePrescription(command.Id, command.DiseaseId, command.PrescriptionId);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.UpdateDiseasePrescription(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnDiseasePrescriptionRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public ICollection<Disease> GetAllDiseases()
        {
            return _repository.GetAll();
        }

        public ICollection<DiseasePrescription> GetAllDiseasePrescription()
        {
            return _repository.GetAllDiseasePrescription();
        }

        public Disease GetDiseaseByName(string name)
        {
            return _repository.GetByName(name);
        }

        public Disease GetDiseaseById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Disease GetDiseaseByCID(string cid)
        {
            return _repository.GetByCID(cid);
        }

        public DiseasePrescription GetDiseasePrescriptionById(Guid id)
        {
            return _repository.GetDiseasePrescriptionById(id);
        }



    }
}
