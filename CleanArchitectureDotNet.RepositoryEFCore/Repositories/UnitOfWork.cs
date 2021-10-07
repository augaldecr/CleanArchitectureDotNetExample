using CleanArchitectureDotNet.Entities.Interfaces;
using CleanArchitectureDotNet.RepositoryEFCore.DataContext;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleanArchitectureDotNetDbContext _dbContext;

        public UnitOfWork(CleanArchitectureDotNetDbContext dbContext) => _dbContext = dbContext;

        public Task<int> SaveChanges()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
