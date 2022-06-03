using Demo.CleanArquitecture.DTOs;
using Demo.CleanArquitecture.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.Presenters
{
    public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<GetProductDTO>>
    {
        public IEnumerable<GetProductDTO> Content { get; private set; }

        public Task Handler(IEnumerable<GetProductDTO> productsDto)
        {
            //en este caso devolvemos el DTO tal cual es
            Content = productsDto;
            return Task.CompletedTask;

            //en el caso de que se nos pida devolverlo como XML aqui abajo aplicariamos logica para realizar esa conversion

        }
    }
}
