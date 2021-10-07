using System.Threading.Tasks;

namespace CleanArchitectureDotNet.UseCasesPorts
{
    public interface IGetAllProductsInputPort
    {
        Task Handle();
    }
}
