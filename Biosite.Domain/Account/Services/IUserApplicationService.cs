using Biosite.Domain.Account.Commands.UserCommands;
using Biosite.Domain.Account.Entities;
using System.Collections.Generic;

namespace Biosite.Domain.Account.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
        ICollection<User> GetAllUsers();
        User GetUserByEmail(string email);
        User GetLogin(string email, string password);
    }
}
