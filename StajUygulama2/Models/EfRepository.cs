using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama2.Models
{
    public class EfRepository : IRepository
    {
        private DataContext context;

        public EfRepository(DataContext _context)
        {
            context = _context;

        }

        public IEnumerable<OgrenciBilgi> OgrenciBilgileri => context.OgrenciBilgileri;

        public IEnumerable<OgrenciAdresBilgi> OgrenciAdresBilgileri => context.OgrenciAdresBilgileri;

        public IEnumerable<OgrenciOkulBilgi> OgrenciOkulBilgileri => context.OgrenciOkulBilgileri;

        public IEnumerable<OgrenciAileBilgi> OgrenciAileBilgileri => context.OgrenciAileBilgileri;


        /// <summary>
        /// Öğrenci bilgilerini veritabanına kaydeder.
        /// </summary>
        /// <param name="newOgrenci"></param>
        /// <returns></returns>
        public int AddOgrenciBilgi(OgrenciBilgi newOgrenci)
        {
            context.OgrenciBilgileri.Add(newOgrenci);
            context.SaveChanges();
            return newOgrenci.Id;
        }

        /// <summary>
        /// Silinmesi istenen öğrenci için silinme tarihi veritabanına eklenir.
        /// </summary>
        /// <param name="ogrenciid"></param>
        public void DeleteOgrenciBilgi(int ogrenciid)
        {
            var entity = GetById(ogrenciid);

            DateTime silinmetarihi = DateTime.Now;
            entity.GetType().GetProperty("SilinmeTarihi").SetValue(entity, silinmetarihi.ToString());

            context.OgrenciBilgileri.Update(entity);
            context.SaveChanges();

        }

        /// <summary>
        /// Id ye göre öğrenci biligileri getirilir.
        /// </summary>
        /// <param name="ogrenciid"></param>
        /// <returns></returns>
        public OgrenciBilgi GetById(int ogrenciid)
        {
            return context.OgrenciBilgileri
                .Include(i => i.OgrenciAdresBilgi)
                .Include(i => i.OgrenciOkulBilgi)
                .Include(i => i.OgrenciAileBilgi)
                .FirstOrDefault(i => i.Id == ogrenciid);
        }


        /// <summary>
        /// filtreleme işlemi gerçekleştirilir
        /// </summary>
        /// <param name="ogrencino"></param>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <returns></returns>
        public IEnumerable<OgrenciBilgi> GetOgrenciBilgileriByFilter(string ogrencino, string ad, string soyad)
        {
            IQueryable<OgrenciBilgi> query = context.OgrenciBilgileri;
            if (ogrencino != null)
            {
                query = query.Where(i => i.OgrenciOkulBilgi.OgrenciNo == ogrencino);
            }

            if (ad != null)
            {
                query = query.Where(i => i.Ad.ToLower().Contains(ad.ToLower()));
            }
            if (soyad != null)
            {
                query = query.Where(i => i.Soyad.ToLower().Contains(soyad.ToLower()));
            }

            return query.Include(i => i.OgrenciAdresBilgi).Include(i => i.OgrenciOkulBilgi).Include(i => i.OgrenciAileBilgi).ToList();
        }

        /// <summary>
        /// değişiklikler update edilir.
        /// </summary>
        /// <param name="updateOgrenci"></param>
        public void UpdateOgrenciBilgi(OgrenciBilgi updateOgrenci, OgrenciBilgi originalOgrenci = null)
        {
            // originalCourse değeri eğer null a eşitse bu durumda veritabanında bilgi seçilir.
            if (originalOgrenci == null)
            {
                originalOgrenci = context.OgrenciBilgileri.Find(updateOgrenci.Id);
            }
            //Ama eğer değer gönderilmişse seçmeye gerek yok.Tracking başlar ve update sorgusu sadece güncellenenler için çalışır.
            else
            {
                context.OgrenciBilgileri.Attach(originalOgrenci);
            }

            originalOgrenci.Donem = updateOgrenci.Donem;
            originalOgrenci.Ad = updateOgrenci.Ad;
            originalOgrenci.Soyad = updateOgrenci.Soyad;
            originalOgrenci.OgrenciAdresBilgi.Eposta = updateOgrenci.OgrenciAdresBilgi.Eposta;
            originalOgrenci.Cinsiyet = updateOgrenci.Cinsiyet;
            originalOgrenci.DogumTarihi = updateOgrenci.DogumTarihi;
            originalOgrenci.DogumYeri = updateOgrenci.DogumYeri;
            originalOgrenci.KanGrubu = updateOgrenci.KanGrubu;
            originalOgrenci.OgrenciOkulBilgi.OgrenciNo = updateOgrenci.OgrenciOkulBilgi.OgrenciNo;
            originalOgrenci.OgrenciOkulBilgi.Sınıf = updateOgrenci.OgrenciOkulBilgi.Sınıf;
            originalOgrenci.OgrenciOkulBilgi.OgrenciTipi = updateOgrenci.OgrenciOkulBilgi.OgrenciTipi;
            originalOgrenci.OgrenciAdresBilgi.Telefon1 = updateOgrenci.OgrenciAdresBilgi.Telefon1;
            originalOgrenci.OgrenciAdresBilgi.Telefon2 = updateOgrenci.OgrenciAdresBilgi.Telefon2;

            originalOgrenci.OgrenciAdresBilgi.Adres1 = updateOgrenci.OgrenciAdresBilgi.Adres1;
            originalOgrenci.OgrenciAdresBilgi.Adres2 = updateOgrenci.OgrenciAdresBilgi.Adres2;
            originalOgrenci.OgrenciAdresBilgi.Semt = updateOgrenci.OgrenciAdresBilgi.Semt;
            originalOgrenci.OgrenciAdresBilgi.Sehir = updateOgrenci.OgrenciAdresBilgi.Sehir;
            originalOgrenci.OgrenciAdresBilgi.Statu = updateOgrenci.OgrenciAdresBilgi.Statu;

            originalOgrenci.OgrenciAileBilgi.AnneBabaDurum = updateOgrenci.OgrenciAileBilgi.AnneBabaDurum;
            originalOgrenci.OgrenciAileBilgi.KiminleKaliyor = updateOgrenci.OgrenciAileBilgi.KiminleKaliyor;
            originalOgrenci.OgrenciAileBilgi.KardesSayisi = updateOgrenci.OgrenciAileBilgi.KardesSayisi;

            originalOgrenci.OgrenciOkulBilgi.Okul = updateOgrenci.OgrenciOkulBilgi.Okul;
            originalOgrenci.OgrenciOkulBilgi.OncekiOkul = updateOgrenci.OgrenciOkulBilgi.OncekiOkul;
            originalOgrenci.OgrenciOkulBilgi.AyrilmaNedeni = updateOgrenci.OgrenciOkulBilgi.AyrilmaNedeni;
            originalOgrenci.OgrenciOkulBilgi.AboneDurumu = updateOgrenci.OgrenciOkulBilgi.AboneDurumu;
            originalOgrenci.OgrenciOkulBilgi.ServisNo = updateOgrenci.OgrenciOkulBilgi.ServisNo;
            originalOgrenci.OgrenciOkulBilgi.OdaNo = updateOgrenci.OgrenciOkulBilgi.OdaNo;
            originalOgrenci.OgrenciOkulBilgi.YatakNo = updateOgrenci.OgrenciOkulBilgi.YatakNo;
            originalOgrenci.OgrenciOkulBilgi.Notlar = updateOgrenci.OgrenciOkulBilgi.Notlar;


            context.SaveChanges();

            //context.OgrenciBilgileri.Update(updateOgrenci);
            //context.SaveChanges();
        }



        //IEnumerable<OgrenciBilgi> IRepository.Listeleme(int ogrenciid)
        //{
        //    IQueryable<OgrenciBilgi> query = context.OgrenciBilgileri;

        //    return query.Include(i => i.OgrenciAdresBilgi).Include(i => i.OgrenciOkulBilgi).Include(i => i.OgrenciAileBilgi).ToList();
        //}
    }
}
