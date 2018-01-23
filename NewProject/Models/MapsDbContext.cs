namespace NewProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MapsDbContext : DbContext
    {
        public MapsDbContext(): base("name=MapsDbContext")
        {
        }

        public virtual DbSet<MapsDB> MapsDB { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapsDB>()
                .Property(e => e.AtractionName)
                .IsUnicode(false);

            modelBuilder.Entity<MapsDB>()
                .Property(e => e.City)
                .IsUnicode(false);
        }
    }
}
