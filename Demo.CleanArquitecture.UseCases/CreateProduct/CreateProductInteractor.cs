using Demo.CleanArquitecture.DTOs;
using Demo.CleanArquitecture.Entities.Interfaces;
using Demo.CleanArquitecture.Entities.POCOs;
using Demo.CleanArquitecture.UseCasesPorts;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handler(CreateProductDTO productDto)
        {
            var newProduct = new Product()
            {
                Name = productDto.ProductName,
                Price = productDto.ProductPrice
            };

            _repository.CreateProduct(newProduct);
            await _unitOfWork.SaveChanges();

            var newProductDto = new GetProductDTO()
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                Price = newProduct.Price
            };

            await _outputPort.Handler(newProductDto);
        }
    }
}
