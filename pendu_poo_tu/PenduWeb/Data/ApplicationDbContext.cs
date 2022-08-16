using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PenduWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Mot> Mots { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}