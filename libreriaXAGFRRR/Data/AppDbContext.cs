using libreriaXAGFRRR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreriaXAGFRRR.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }
        public DbSet<Books> Books { get; set; }
    }
}
