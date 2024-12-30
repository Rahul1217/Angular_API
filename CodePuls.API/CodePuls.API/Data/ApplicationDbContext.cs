using CodePuls.API.Models.Domain;
using CodePulse.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePuls.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
    }
}
