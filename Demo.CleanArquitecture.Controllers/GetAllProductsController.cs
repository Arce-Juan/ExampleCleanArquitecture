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
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _inputPort;
        readonly IGetAllProductsOutputPort _outputPort;
        

        public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<GetProductDTO>> GetAllProduct()
        {
            await _inputPort.Handler();
            return ((IPresenter<IEnumerable<GetProductDTO>>)_outputPort).Content;
        }
    }
}
