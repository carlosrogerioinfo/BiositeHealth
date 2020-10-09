using Biosite.Domain.Account.Entities;
using Biosite.Domain.Account.Repositories;
using Biosite.Domain.Account.Specs;
using Biosite.Infra.Persistence.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace Biosite.Infra.Repositories.Account
{
    public class UserRepository : IUserRepository
    {
        private readonly BiositeDataContext _context;

        public UserRepository(BiositeDataContext context)
        {
            _context = context;
        }

        public User GetByAuthorizationCode(string authorizationCode)
        {
            return _context
                .Users
                .Where(UserSpecs.GetByAuthorizationCode(authorizationCode))
                .FirstOrDefault();
        }

        public User GetUserByUsername(string username)
        {
            return _context
                .Users
                .Where(UserSpecs.GetByUsername(username))
                .FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context
                .Users
                .Where(UserSpecs.GetByEmail(email))
                .FirstOrDefault();
        }

        public User GetLogin(string email, string password)
        {
            return _context
                .Users
                .Where(UserSpecs.GetByEmailPassword(email, password))
                .FirstOrDefault();
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
        }

        public void Update(User user)
        {
            _context.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
        }

        public ICollection<User> GetAll()
        {
            var listagem = _context.Users.Where(x => x.Email.Equals("esterpereira@gmail.com")).FirstOrDefault();
            return _context.Users.ToList();
        }



    }
}
