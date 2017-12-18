using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DionIS.DAL.Domen
{
    public class Kasa
    {
        public int KasaId { get; set; }
        public string ImeRadnika { get; set; }
        public decimal Racun { get; set; }
        public DateTime DatumIzdavanja { get; set; }
    }
}
