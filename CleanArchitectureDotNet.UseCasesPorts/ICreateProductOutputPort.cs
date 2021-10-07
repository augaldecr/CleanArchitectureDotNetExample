using CleanArchitectureDotNet.DTOs;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.UseCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
