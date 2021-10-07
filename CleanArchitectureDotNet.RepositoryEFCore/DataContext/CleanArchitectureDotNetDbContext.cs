using CleanArchitectureDotNet.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDotNet.RepositoryEFCore.DataContext
{
    public class CleanArchitectureDotNetDbContext : DbContext
    {
        public CleanArchitectureDotNetDbContext(DbContextOptions<CleanArchitectureDotNetDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
