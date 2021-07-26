using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama2.Models
{
    public class OgrenciBilgi
    {
        public int Id { get;set; }
        public string Donem { get; set; }
        
        [Required(ErrorMessage = "Ad Alanı boş geçilemez")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyadı Alanı boş geçilemez")]
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string KanGrubu { get; set; }
        public string SilinmeTarihi { get; set; }

       public int OgrenciAdresBilgiId { get; set; }
       public OgrenciAdresBilgi OgrenciAdresBilgi { get; set; }

       public int OgrenciAileBilgiId { get; set; }
       public OgrenciAileBilgi OgrenciAileBilgi { get; set; }

       public int OgrenciOkulBilgiId { get; set; }
        public OgrenciOkulBilgi OgrenciOkulBilgi { get; set; }
    }
}
