using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using ProductWebApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ProductWebApi
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions) : base(dbContextOptions)
        {
            try
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public DbSet<Product> Products { get; set; }
    }
}
