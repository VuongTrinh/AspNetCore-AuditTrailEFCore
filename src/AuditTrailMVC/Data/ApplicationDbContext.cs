using Microsoft.EntityFrameworkCore;

namespace AuditTrailMVC.Data
{
    public class ApplicationDbContext : AuditableIdentityContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AuditTrailMVC.Models.Product> Product { get; set; }
    }
}
