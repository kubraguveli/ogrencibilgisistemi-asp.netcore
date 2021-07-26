using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama2.Models
{
    public class OgrenciOkulBilgi
    {
        public int Id { get; set; }
        public string OgrenciNo { get; set; }
        public string Sınıf { get; set; }
        public string OgrenciTipi { get; set; }
        public string Okul { get; set; }
        public string OncekiOkul { get; set; }
        public string AyrilmaNedeni { get; set; }
        public string AboneDurumu { get; set; }
        public string ServisNo { get; set; }
        public string OdaNo { get; set; }
        public string YatakNo { get; set; }
        public string Notlar { get; set; }
        
    }
}
