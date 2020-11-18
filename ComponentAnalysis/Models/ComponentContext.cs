using Microsoft.EntityFrameworkCore;

namespace ComponentAnalysis.Models
{
    public class ComponentContext : DbContext
    {
        public ComponentContext(DbContextOptions<ComponentContext> options) : base(options)
        {
        }


        public DbSet<Component> Components { get; set; }
    }
}
