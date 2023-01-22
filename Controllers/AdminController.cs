using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.sınıflar;
namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
            Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.yeteneklers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniYetenek(yetenekler y)
        {
            c.yeteneklers.Add(y);
            c.SaveChanges();
            return View();

        }
        public ActionResult YetenekSil(int id)
        {
            var deger = c.yeteneklers.Find(id);
            c.yeteneklers.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
            [HttpGet]
           public ActionResult YetenekGetir(int id)
        {
            var deger = c.yeteneklers.Find(id);
            c.SaveChanges();
            return View("YetenekGetir",deger);
        }
        [HttpPost]
        public ActionResult YetenekGetir(yetenekler y)
        {
            var x = c.yeteneklers.Find(y.id);
            x.yetenekaciklama = y.yetenekaciklama;
            x.deger = y.deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}