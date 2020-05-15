namespace Gestion_Employe.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employes()
        {
            Menu = new HashSet<Menu>();
        }

        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Matricule { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenom { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [StringLength(50)]
        public string Sexe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Nbrenfant { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Anciennete { get; set; }

        public double Salairebase { get; set; }

        [Required]
        [StringLength(50)]
        public string Staut { get; set; }

        public double Primespeciale { get; set; }

        public double Primeipres { get; set; }

        [Required]
        [StringLength(50)]
        public string Services { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu { get; set; }
    }
}
