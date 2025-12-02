using Microsoft.EntityFrameworkCore;
using Rocky_DOTNET_10.Models;

namespace Rocky_DOTNET_10.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
