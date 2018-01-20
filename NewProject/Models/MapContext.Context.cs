
namespace NewProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MapsEntities : DbContext
    {
        public MapsEntities() : base("name=MapsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MapsDB> MapsDB { get; set; }
    }
}
