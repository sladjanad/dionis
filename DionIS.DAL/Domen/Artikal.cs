namespace DionIS.DAL.Domen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OsnovniKatalozi.Artikal")]
    public partial class Artikal
    {
        public short ArtikalId { get; set; }

        public byte JedinicaMjereId { get; set; }

        [Required]
        [StringLength(30)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(150)]
        public string Naziv { get; set; }

        [StringLength(300)]
        public string Opis { get; set; }

        public bool Aktivan { get; set; }

        public string Napomena { get; set; }

        public string Ilija { get; set; }

        public string Proba1 { get; set; }

        public virtual JedinicaMjere JedinicaMjere { get; set; }

        public virtual JedinicaMjere JedinicaMjere1 { get; set; }
    }
}
