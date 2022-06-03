using Demo.CleanArquitecture.Entities.POCOs;
using System.Collections.Generic;

namespace Demo.CleanArquitecture.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}
