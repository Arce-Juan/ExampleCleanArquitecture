using Demo.CleanArquitecture.DTOs;
using Demo.CleanArquitecture.Presenters;
using Demo.CleanArquitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Demo.CleanArquitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort _inputPort;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpPost]
        public async Task<GetProductDTO> CreateProduct(CreateProductDTO productDTO)
        {
            await _inputPort.Handler(productDTO);
            return ((IPresenter<GetProductDTO>)_outputPort).Content;
        }
    }
}
