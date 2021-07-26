using Microsoft.AspNetCore.Mvc;
using StajUygulama2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama2.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository _repository)
        {
            repository = _repository;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OgrenciBilgi newOgrenci)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }

            repository.AddOgrenciBilgi(newOgrenci);
            return RedirectToAction("List");

            //try
            //{
            //    repository.AddOgrenciBilgi(newOgrenci);
            //    return RedirectToAction("List");
            //}
            //catch (Exception ex)
            //{
            //    var msj = ex.Message;
            //}
            //return View("Index");
        }

        public IActionResult List(string ogrencino = null, string ad = null, string soyad = null)
        {
            var ogrenciler = repository.GetOgrenciBilgileriByFilter(ogrencino, ad, soyad);
            ViewBag.OgrenciNo = ogrencino;
            ViewBag.AdSoyad = ad;
            ViewBag.AdSoyad = soyad;

            return View(ogrenciler);
        }

        public IActionResult Update(int id)
        {
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(OgrenciBilgi entity, OgrenciBilgi original)
        {
            repository.UpdateOgrenciBilgi(entity, original);
            return RedirectToAction(nameof(List));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.DeleteOgrenciBilgi(id);
            return RedirectToAction("List");
        }
    }
}
