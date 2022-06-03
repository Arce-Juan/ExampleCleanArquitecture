using Demo.CleanArquitecture.DTOs;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.UseCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handler(GetProductDTO productDto);
    }
}
