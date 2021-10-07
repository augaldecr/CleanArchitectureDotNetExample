using CleanArchitectureDotNet.DTOs;
using CleanArchitectureDotNet.UseCasesPorts;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.Presenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
