using CleanArchitectureDotNet.DTOs;
using CleanArchitectureDotNet.Entities.Interfaces;
using CleanArchitectureDotNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        private readonly IProductRepository _repository;
        private readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort) =>
            (_repository, _outputPort) =
            (repository, outputPort);

        public Task Handle()
        {
            var Products = _repository.GetAll().Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
            });

            _outputPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
