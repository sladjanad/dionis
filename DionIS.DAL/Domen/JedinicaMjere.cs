namespace DionIS.DAL.Domen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OsnovniKatalozi.JedinicaMjere")]
    public partial class JedinicaMjere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JedinicaMjere()
        {
            Artikals = new HashSet<Artikal>();
            Artikals1 = new HashSet<Artikal>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte JedinicaMjereId { get; set; }

        [Required]
        [StringLength(3)]
        public string Oznaka { get; set; }

        [Required]
        [StringLength(30)]
        public string Naziv { get; set; }

        public int Broj { get; set; }

        [Required]
        [StringLength(30)]
        public string Mirko { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artikal> Artikals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artikal> Artikals1 { get; set; }
    }
}
