using Biosite.Domain.Account.Entities;
using System;
using System.Linq.Expressions;

namespace Biosite.Domain.Account.Specs
{
    public static class UserSpecs
    {
        public static Expression<Func<User, bool>> GetByUsername(string username)
        {
            return x => x.Username == username;
        }

        public static Expression<Func<User, bool>> GetByAuthorizationCode(string authorizationCode)
        {
            return x => x.AuthorizationCode == authorizationCode;
        }

        public static Expression<Func<User, bool>> GetByEmail(string email)
        {
            return x => x.Email == email;
        }

        public static Expression<Func<User, bool>> GetByEmailPassword(string email, string password)
        {
            return x => x.Email == email && x.Password == password;
        }

    }
}
