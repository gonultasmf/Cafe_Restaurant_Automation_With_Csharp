using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Otomat
{
    public class SiparisDB
    {
        public int Id { get; set; }
        public string MasaAd { get; set; }
        public string IslemNo { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }
        public DateTime Tarih { get; set; }
        public double Miktar { get; set; }
        public double AlisFiyat { get; set; }
        public double Fiyat { get; set; }
        public double ToplamTutar { get; set; }
        public string Kategori { get; set; }
        public string Personel { get; set; }
    }
}
