using System.Threading.Tasks;

namespace CleanArchitectureDotNet.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
