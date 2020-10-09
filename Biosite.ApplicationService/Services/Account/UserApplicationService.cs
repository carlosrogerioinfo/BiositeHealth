using DomainNotificationHelper.Events;
using Biosite.Domain.Account.Commands.UserCommands;
using Biosite.Domain.Account.Entities;
using Biosite.Domain.Account.Events.UserEvents;
using Biosite.Domain.Account.Repositories;
using Biosite.Domain.Account.Services;
using Biosite.Infra.Transaction;
using System.Collections.Generic;
using Biosite.SharedKernel.Library;

namespace Biosite.ApplicationService.Services.Account
{
    public class UserApplicationService : ApplicationService, IUserApplicationService
    {
        private readonly IUserRepository _repository;

        public UserApplicationService(IUserRepository repository, IUnitOfWork uow)
            : base(uow)
        {
            _repository = repository;
        }

        public User Register(RegisterUserCommand command)
        {
            // Cria a instâcia do usuário
            var user = new User(command.Email, command.Username, command.Password);

            // Tenta registrar o usuário
            user.Register();

            // Salva as alterações da tabela no contexto do banco de dados
            _repository.Save(user);

            // Chama o commit
            if(Commit())
            {
                // Dispara o evento de usuário registrado
                DomainEvent.Raise(new OnUserRegisteredEvent(user));

                // Retorna o usuário
                return user;
            }

            // Se não comitou, retorna nulo
            return null;
        }

        public ICollection<User> GetAllUsers()
        {
            return _repository.GetAll();
        }

        public User GetUserByEmail(string email)
        {
            return _repository.GetUserByEmail(email);
        }
        public User GetLogin(string email, string password)
        {
            //password = SharedFunctions.EncryptPassword("123456");

            var user  = _repository.GetLogin(email, SharedFunctions.EncryptPassword(password));

            if (user != null)
            {
                if (!user.Active && !user.Verified)
                {
                    user = null;
                }
            }

            return user;
        }
    }
}
