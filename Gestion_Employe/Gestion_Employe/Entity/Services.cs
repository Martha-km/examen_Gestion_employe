namespace Gestion_Employe.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Services
    {
        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Nbreemployes { get; set; }
    }
}
