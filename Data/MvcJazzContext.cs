using Microsoft.EntityFrameworkCore;
using MvcJazz.Models;

namespace MvcJazz.Data
{
    public class MvcJazzContext : DbContext
    {
        public MvcJazzContext (DbContextOptions<MvcJazzContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Album { get; set; }
    }
}