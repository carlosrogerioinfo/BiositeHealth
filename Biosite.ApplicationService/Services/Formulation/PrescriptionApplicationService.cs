using DomainNotificationHelper.Events;
using Biosite.Domain.Account.Commands.UserCommands;
using Biosite.Domain.Account.Entities;
using Biosite.Domain.Account.Events.UserEvents;
using Biosite.Domain.Account.Repositories;
using Biosite.Domain.Account.Services;
using Biosite.Infra.Transaction;
using System.Collections.Generic;
using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Formulation.Repositories;
using Biosite.Domain.Formulation.Commands.FormulationCommands;
using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Events.FormulationEvents;
using System;

namespace Biosite.ApplicationService.Services.Formulation
{
    public class PrescriptionApplicationService : ApplicationService, IPrescriptionApplicationService
    {
        private readonly IPrescriptionRepository _repository;

        public PrescriptionApplicationService(IPrescriptionRepository repository, IUnitOfWork uow)
            : base(uow)
        {
            _repository = repository;
        }

        public Prescription Register(RegisterPrescriptionCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Prescription(command.Name, command.Description);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Save(domain);

            // Chama o commit
            if(Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnPrescriptionRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public Prescription Update(UpdatePrescriptionCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Prescription(command.Id, command.Name, command.Description);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Update(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnPrescriptionRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public ICollection<Prescription> GetAllPrescriptions()
        {
            return _repository.GetAll();
        }

        public ICollection<PrescriptionDetail> GetAllPrescriptionDetails()
        {
            return _repository.GetAllPrescriptionDetails();
        }

        public Prescription GetPrescriptionByDescription(string description)
        {
            return _repository.GetByDescription(description);
        }

        public Prescription GetPrescriptionById(Guid id)
        {
            return _repository.GetById(id);
        }

        public ICollection<PrescriptionDetail> GetPrescriptionDetailById(Guid id)
        {
            return _repository.GetPrescriptionDetailById(id);
        }


        public PrescriptionDetail RegisterPrescriptionDetail(RegisterPrescriptionDetailCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new PrescriptionDetail(command.Dosage, command.Group, command.Posology, command.Information, command.Note, command.PrescriptionId, command.NutraceuticalId);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.SavePrescriptionDetail(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnPrescriptionDetailRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public PrescriptionDetail UpdatePrescriptionDetail(UpdatePrescriptionDetailCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new PrescriptionDetail (command.Id, command.Dosage, command.Group, command.Posology, command.Information, command.Note, command.PrescriptionId, command.NutraceuticalId);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.UpdatePrescriptionDetail(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnPrescriptionDetailRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }


    }
}
