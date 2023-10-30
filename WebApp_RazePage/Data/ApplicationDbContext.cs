using Microsoft.EntityFrameworkCore;

using WebApp_RazePage.Model;

namespace WebApp_RazePage.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        
        
        
        }
        
        public DbSet<Category> Categories { get; set; }
    }
}
