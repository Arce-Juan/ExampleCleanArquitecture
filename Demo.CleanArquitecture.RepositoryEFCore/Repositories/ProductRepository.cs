using Demo.CleanArquitecture.Entities.Interfaces;
using Demo.CleanArquitecture.Entities.POCOs;
using Demo.CleanArquitecture.RepositoryEFCore.DataContext;
using System.Collections.Generic;

namespace Demo.CleanArquitecture.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly DataBaseContext _context;

        public ProductRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
