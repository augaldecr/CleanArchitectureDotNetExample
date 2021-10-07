using CleanArchitectureDotNet.Entities.POCOs;
using System.Collections.Generic;

namespace CleanArchitectureDotNet.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}
