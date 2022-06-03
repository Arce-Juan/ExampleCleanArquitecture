using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Demo.CleanArquitecture.RepositoryEFCore.DataContext
{
    internal class ContextFactory : IDesignTimeDbContextFactory<DataBaseContext>
    {
        public DataBaseContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DataBaseContext>();
            optionBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;database=DemoCleanArquitecture"
                //"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoCleanArquitecture;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
            return new DataBaseContext(optionBuilder.Options);
        }
    }
}