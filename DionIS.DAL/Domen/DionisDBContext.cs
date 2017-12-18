namespace DionIS.DAL.Domen
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DionisDBContext : DbContext
    {
        public DionisDBContext()
            : base("name=DionisDBContext")
        {
        }

        public virtual DbSet<Artikal> Artikals { get; set; }
        public virtual DbSet<JedinicaMjere> JedinicaMjeres { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<Kasa> Kasas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikal>()
                .Property(e => e.Sifra)
                .IsUnicode(false);

            modelBuilder.Entity<JedinicaMjere>()
                .Property(e => e.Oznaka)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JedinicaMjere>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<JedinicaMjere>()
                .HasMany(e => e.Artikals)
                .WithRequired(e => e.JedinicaMjere)
                .HasForeignKey(e => e.JedinicaMjereId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JedinicaMjere>()
                .HasMany(e => e.Artikals1)
                .WithRequired(e => e.JedinicaMjere1)
                .HasForeignKey(e => e.JedinicaMjereId)
                .WillCascadeOnDelete(false);
        }
    }
}
