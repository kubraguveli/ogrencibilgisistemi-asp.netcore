using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama2.Models
{
    public interface IRepository
    {
        IEnumerable<OgrenciAdresBilgi> OgrenciAdresBilgileri { get; }
        IEnumerable<OgrenciOkulBilgi> OgrenciOkulBilgileri { get; }
        IEnumerable<OgrenciAileBilgi> OgrenciAileBilgileri { get; }
        IEnumerable<OgrenciBilgi> OgrenciBilgileri { get; }
        OgrenciBilgi GetById(int hastaid);

        int AddOgrenciBilgi(OgrenciBilgi newOgrenci);

        //IEnumerable<OgrenciBilgi> Listeleme(int newOgrenci);

        IEnumerable<OgrenciBilgi> GetOgrenciBilgileriByFilter(string ogrencino, string ad, string soyad);

        void UpdateOgrenciBilgi(OgrenciBilgi updateOgrenci, OgrenciBilgi originalOgrenci = null);
        void DeleteOgrenciBilgi(int ogrenciid);
    }
}
