using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Events.FormulationEvents;
using Biosite.Domain.Substance.Commands.SubstanceCommands;
using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using Biosite.Domain.Substance.Events.NutraceuticalEvents;
using Biosite.Domain.Substance.Repositories;
using Biosite.Domain.Substance.Services;
using Biosite.Infra.Transaction;
using DomainNotificationHelper.Events;
using System;
using System.Collections.Generic;

namespace Biosite.ApplicationService.Services.Substance
{
    public class NutraceuticalApplicationService : ApplicationService, INutraceuticalApplicationService
    {
        private readonly INutraceuticalRepository _repository;

        public NutraceuticalApplicationService(INutraceuticalRepository repository, IUnitOfWork uow)
            : base(uow)
        {
            _repository = repository;
        }

        public Nutraceutical Update(UpdateNutraceuticalCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Nutraceutical(command.Id, command.Name, command.Pharmacology, command.ActionMechanism, command.Indications, command.AgainstIndications, command.AdverseReactions,
                command.DrugInteractions, command.DescriptionDosages, command.RecomendedDosages, command.NutraceuticalReferences, command.NutraceuticalType, command.MinDosage,
                command.MaxDosage, command.Unity, command.MedicalOnly, command.CommonName);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Update(domain);

            // Chama o commit
            if (Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnNutraceuticalRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public Nutraceutical Register(RegisterNutraceuticalCommand command)
        {
            // Cria a instâcia do usuário
            var domain = new Nutraceutical(command.Name, command.Pharmacology, command.ActionMechanism, command.Indications, command.AgainstIndications, command.AdverseReactions, 
                command.DrugInteractions, command.DescriptionDosages, command.RecomendedDosages, command.NutraceuticalReferences, command.NutraceuticalType, command.MinDosage,
                command.MaxDosage, command.Unity, command.MedicalOnly, command.CommonName);

            // Tenta ações e regras de negócio no domínio
            //domain.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Save(domain);

            // Chama o commit
            if(Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnNutraceuticalRegisteredEvent(domain));

                // Retorna o usuário
                return domain;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public ICollection<Nutraceutical> GetAllNutraceuticals()
        {
            return _repository.GetAll();
        }

        public Nutraceutical GetNutraceuticalByName(string name)
        {
            return _repository.GetByName (name);
        }

        public Nutraceutical GetNutraceuticalById(Guid id)
        {
            return _repository.GetById(id);
        }

        public ICollection<Nutraceutical> GetNutraceuticalByNutraceuticalType(NutraceuticalType nutraceuticalType)
        {
            return _repository.GetByNutraceuticalType(nutraceuticalType);
        }

        public ICollection<Nutraceutical> GetTenMostRecentsNutraceuticals()
        {
            return _repository.GetTenMostRecentsNutraceuticals();
        }
    }
}
