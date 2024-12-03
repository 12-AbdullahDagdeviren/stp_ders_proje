using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_takip_programi.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string FirmaAdi { get; set; }
        public int Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

        public virtual ICollection<Satis> Urunler { get; set; } = new HashSet<Satis>();

    }
}
