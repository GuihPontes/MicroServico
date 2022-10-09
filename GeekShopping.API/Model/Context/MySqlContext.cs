using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions options) : base(options)
        {
        }

        protected MySqlContext()
        {
        }

        public DbSet<ProductModel> Produtos { get; set; }

    }
}
