using Demo.CleanArquitecture.Entities.Interfaces;
using Demo.CleanArquitecture.RepositoryEFCore.DataContext;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly DataBaseContext _context;

        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }

        public Task<int> SaveChanges()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
