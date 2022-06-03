using System.Threading.Tasks;

namespace Demo.CleanArquitecture.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
