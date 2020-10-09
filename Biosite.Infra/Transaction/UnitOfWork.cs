using Biosite.Infra.Persistence.Contexts;

namespace Biosite.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BiositeDataContext _context;

        public UnitOfWork(BiositeDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Não faz nada :)
        }
    }
}
