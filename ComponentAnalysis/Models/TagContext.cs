using Microsoft.EntityFrameworkCore;

namespace ComponentAnalysis.Models
{
    public class TagContext : DbContext
    {
        public TagContext(DbContextOptions<TagContext> options) : base(options)
        {
        }


        public DbSet<Tag> Tags { get; set; }
    }
}
