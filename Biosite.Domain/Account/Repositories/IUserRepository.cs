using Biosite.Domain.Account.Entities;
using System.Collections.Generic;

namespace Biosite.Domain.Account.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
        void Update(User user);
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        User GetByAuthorizationCode(string authorizationCode);
        User GetLogin(string email, string password);
        ICollection<User> GetAll();
    }
}
