using CleanArchitectureDotNet.DTOs;
using CleanArchitectureDotNet.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.Presenters
{
    public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
    {
        public IEnumerable<ProductDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDTO> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
