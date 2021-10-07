using CleanArchitectureDotNet.Entities.Interfaces;
using CleanArchitectureDotNet.Entities.POCOs;
using CleanArchitectureDotNet.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CleanArchitectureDotNetDbContext _dbContext;

        public ProductRepository(CleanArchitectureDotNetDbContext dbContext) => _dbContext = dbContext;

        public void CreateProduct(Product product)
        {
            _dbContext.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products;
        }
    }
}
