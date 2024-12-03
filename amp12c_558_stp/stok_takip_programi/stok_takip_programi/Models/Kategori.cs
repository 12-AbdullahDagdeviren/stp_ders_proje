using stok_takip_programi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_takip_programi.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        // Bir katergorinin birden fazla ürünü olabilir

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
