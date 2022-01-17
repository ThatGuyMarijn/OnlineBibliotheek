using Microsoft.EntityFrameworkCore;
using OnlineBibliotheek.Data.Models;

namespace OnlineBibliotheek.Data
{
    public partial class BibliotheekDbContext : DbContext
    {
        public BibliotheekDbContext()
        {
        }

        public BibliotheekDbContext(DbContextOptions<BibliotheekDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Boek> Boeken { get; set; }
        public virtual DbSet<Auteur> Auteurs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
