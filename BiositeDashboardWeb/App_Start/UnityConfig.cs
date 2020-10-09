using DomainNotificationHelper;
using DomainNotificationHelper.Events;
using DomainNotificationHelper.Handlers;

using Biosite.ApplicationService.Handlers.Account;
using Biosite.ApplicationService.Services.Account;
using Biosite.Domain.Account.Events.UserEvents;
using Biosite.Domain.Account.Repositories;
using Biosite.Domain.Account.Services;
using Biosite.Infra.Persistence.Contexts;
using Biosite.Infra.Repositories.Account;
using Biosite.Infra.Transaction;

using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;
using Biosite.Domain.Problem.Repositories;
using Biosite.Domain.Formulation.Repositories;
using Biosite.Infra.Repositories.Formulation;
using Biosite.Infra.Repositories.Problem;
using Biosite.Domain.Problem.Services;
using Biosite.ApplicationService.Services.Formulation;
using Biosite.ApplicationService.Services.Problem;
using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Problem.Events.ProblemEvents;
using Biosite.ApplicationService.Handlers.Formulation;
using Biosite.ApplicationService.Handlers.Problem;
using Biosite.Domain.Formulation.Events.FormulationEvents;
using Biosite.Domain.ExamName.Repositories;
using Biosite.Domain.ExamName.Services;
using Biosite.Domain.ExamName.Events.ExamNameEvents;
using Biosite.Infra.Repositories.ExamName;
using Biosite.ApplicationService.Services.ExamName;
using Biosite.ApplicationService.Handlers.ExamName;
using Biosite.Domain.Substance.Repositories;
using Biosite.Infra.Repositories.Substance;
using Biosite.Domain.Substance.Services;
using Biosite.ApplicationService.Services.Substance;
using Biosite.Domain.Substance.Events.NutraceuticalEvents;
using Biosite.ApplicationService.Handlers.Substance;

namespace BiositeDashBoardWeb
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // DataContext ORM and UoW
            container.RegisterType<BiositeDataContext, BiositeDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            // Repository of Domains
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDiseaseRepository, DiseaseRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPrescriptionRepository, PrescriptionRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IExamRepository, ExamRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<INutraceuticalRepository, NutraceuticalRepository>(new HierarchicalLifetimeManager());


            // Application Service of Domains
            container.RegisterType<IUserApplicationService, UserApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDiseaseApplicationService, DiseaseApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPrescriptionApplicationService, PrescriptionApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IExamApplicationService, ExamApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<INutraceuticalApplicationService, NutraceuticalApplicationService>(new HierarchicalLifetimeManager());

            // Notifications
            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandler<OnUserRegisteredEvent>, OnUserRegisteredHandler>();

            container.RegisterType<IHandler<OnDiseaseRegisteredEvent>, OnDiseaseRegisteredHandler>();
            container.RegisterType<IHandler<OnDiseasePrescriptionRegisteredEvent>, OnDiseasePrescriptionRegisteredHandler>();

            container.RegisterType<IHandler<OnPrescriptionRegisteredEvent>, OnPrescriptionRegisteredHandler>();
            container.RegisterType<IHandler<OnPrescriptionDetailRegisteredEvent>, OnPrescriptionDetailRegisteredHandler>();

            container.RegisterType<IHandler<OnExamRegisteredEvent>, OnExamRegisteredHandler>();
            container.RegisterType<IHandler<OnNutraceuticalRegisteredEvent>, OnNutraceuticalRegisteredHandler>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}