namespace BugTracker.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BugEntities : DbContext
    {
        public BugEntities()
            : base("name=BugEntities")
        {
        }

        public virtual DbSet<BugLog> BugLogs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Principal> Principals { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Principals)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Principal>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Principal>()
                .Property(e => e.PostCode)
                .IsUnicode(false);
        }
    }
}
