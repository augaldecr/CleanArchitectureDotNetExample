using CleanArchitectureDotNet.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.UseCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDTO> products);
    }
}
