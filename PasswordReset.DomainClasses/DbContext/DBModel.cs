using System.Data.Entity;
using PasswordReset.DomainClasses.Model;

namespace PasswordReset.DomainClasses.DbContext
{
    public partial class DBModel : System.Data.Entity.DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<KBAD_USERS_DB> KBAD_USERS_DB { get; set; }
        public virtual DbSet<KBAD_USERS_AD> KBAD_USERS_AD { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KBAD_USERS_DB>()
                .Property(e => e.FullName)
                .IsFixedLength();

            modelBuilder.Entity<KBAD_USERS_DB>()
                .Property(e => e.LogOnName)
                .IsFixedLength();
            modelBuilder.Entity<KBAD_USERS_AD>()
    .Property(e => e.FullName)
    .IsFixedLength();

            modelBuilder.Entity<KBAD_USERS_AD>()
                .Property(e => e.LogOnName)
                .IsFixedLength();
        }
    }
}
