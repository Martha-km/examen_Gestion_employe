namespace Gestion_Employe.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGestionEmployes : DbContext
    {
        public ModelGestionEmployes()
            : base("name=ModelGestionEmployes")
        {
        }

        public virtual DbSet<Employes> Employes { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Services> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employes>()
                .Property(e => e.Matricule)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employes>()
                .Property(e => e.Nbrenfant)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employes>()
                .Property(e => e.Anciennete)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employes>()
                .HasMany(e => e.Menu)
                .WithRequired(e => e.Employes)
                .HasForeignKey(e => e.Id_Employes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .HasOptional(e => e.Menu1)
                .WithRequired(e => e.Menu2);

            modelBuilder.Entity<Services>()
                .Property(e => e.Nbreemployes)
                .HasPrecision(18, 0);
        }
    }
}
