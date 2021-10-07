using CleanArchitectureDotNet.DTOs;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}
