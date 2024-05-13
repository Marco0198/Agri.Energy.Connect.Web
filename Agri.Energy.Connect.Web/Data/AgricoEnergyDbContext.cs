using Agri.Energy.Connect.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Agri.Energy.Connect.Web.Data
{
    public class AgricoEnergyDbContext : DbContext
    {
        public AgricoEnergyDbContext(DbContextOptions<AgricoEnergyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // public DbSet<Tag> Tags { get; set; }
        // public DbSet<BlogPostLike> BlogPostLike { get; set; }
        // public DbSet<BlogPostComment> BlogPostComment { get; set; }
    }
}
