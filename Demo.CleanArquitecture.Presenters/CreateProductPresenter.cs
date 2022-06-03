using Demo.CleanArquitecture.DTOs;
using Demo.CleanArquitecture.UseCasesPorts;
using System.Threading.Tasks;

namespace Demo.CleanArquitecture.Presenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<GetProductDTO>
    {
        public GetProductDTO Content { get; private set; }

        public Task Handler(GetProductDTO productDto)
        {
            //en este caso devolvemos el DTO tal cual es
            Content = productDto;
            return Task.CompletedTask;

            //en el caso de que se nos pida devolverlo como XML aqui abajo aplicariamos logica para realizar esa conversion
        }
    }
}
