namespace Gestion_Employe.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }

        public int Id_Services { get; set; }

        public int Id_Employes { get; set; }

        public virtual Employes Employes { get; set; }

        public virtual Menu Menu1 { get; set; }

        public virtual Menu Menu2 { get; set; }
    }
}
