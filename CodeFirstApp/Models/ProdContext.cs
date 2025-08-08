using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Models
{
    public class ProdContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        public ProdContext(DbContextOptions<ProdContext> options) :base(options) 
        {

        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=SANKAR; database =Kanini; integrated security=true; trustservercertificate=true;");

        }


    }
}
