using chapter2.Models;
using Microsoft.EntityFrameworkCore;

namespace chapter2.data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrders> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }
       
    }
}
