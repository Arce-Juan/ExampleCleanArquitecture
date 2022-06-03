using Demo.CleanArquitecture.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.UseCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handler(IEnumerable<GetProductDTO> productsDto);
    }
}
