using Demo.CleanArquitecture.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace Demo.CleanArquitecture.RepositoryEFCore.DataContext
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
