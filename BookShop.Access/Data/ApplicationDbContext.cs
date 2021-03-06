using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bio> Bios { get; set; }
    }
}
