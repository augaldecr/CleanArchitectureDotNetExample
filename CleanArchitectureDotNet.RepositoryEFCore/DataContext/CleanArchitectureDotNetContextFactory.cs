using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitectureDotNet.RepositoryEFCore.DataContext
{
    class CleanArchitectureDotNetContextFactory : IDesignTimeDbContextFactory<CleanArchitectureDotNetDbContext>
    {
        public CleanArchitectureDotNetDbContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<CleanArchitectureDotNetDbContext>();
            OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=CleanArchitectureDotNet");
            return new CleanArchitectureDotNetDbContext(OptionsBuilder.Options);
        }
    }
}
