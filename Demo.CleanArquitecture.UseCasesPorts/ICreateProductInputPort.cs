using Demo.CleanArquitecture.DTOs;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handler(CreateProductDTO productDto);
    }
}
