using Microsoft.EntityFrameworkCore;
using Prog2SocialMedia.Models;

namespace Prog2SocialMedia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        // Norādam kādas tabulas būs mūsu datubāzē
        public DbSet<Post> Posts => Set<Post>();
    }
}
