using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using Skill_CodeFirstEntity.Models.sınıflar;


namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.yeteneklers.ToList();
            return View(degerler);
        }
    }
}