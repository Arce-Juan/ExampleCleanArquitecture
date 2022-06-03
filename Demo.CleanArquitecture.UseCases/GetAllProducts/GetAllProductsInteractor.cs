using Demo.CleanArquitecture.DTOs;
using Demo.CleanArquitecture.Entities.Interfaces;
using Demo.CleanArquitecture.UseCasesPorts;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsInteractor(IProductRepository repository, IUnitOfWork unitOfWork, IGetAllProductsOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public Task Handler()
        {
            var products = _repository.GetAll().Select( p =>
                new GetProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }
            );

            _outputPort.Handler(products);
            return Task.CompletedTask;

        }
    }
}

