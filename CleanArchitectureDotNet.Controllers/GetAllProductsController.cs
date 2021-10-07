using CleanArchitectureDotNet.DTOs;
using CleanArchitectureDotNet.Presenters;
using CleanArchitectureDotNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _inputPort;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)_outputPort).Content;
        }
    }
}
