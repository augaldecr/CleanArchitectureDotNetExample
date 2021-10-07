using CleanArchitectureDotNet.DTOs;
using CleanArchitectureDotNet.Entities.Interfaces;
using CleanArchitectureDotNet.Entities.POCOs;
using CleanArchitectureDotNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        private readonly IProductRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateProductOutputPort _outputPort;

        public CreateProductInteractor(IProductRepository repository,
                                       IUnitOfWork unitOfWork,
                                       ICreateProductOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = 
            (repository, unitOfWork, outputPort);

        public async Task Handle(CreateProductDTO product)
        {
            Product NewProduct = new()
            {
                Name = product.ProductName,
            };
            _repository.CreateProduct(NewProduct);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new ProductDTO
            {
                Id = NewProduct.Id,
                Name = NewProduct.Name,
            });

        }
    }
}
