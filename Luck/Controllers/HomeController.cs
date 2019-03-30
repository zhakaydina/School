using Luck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Luck.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Mugalim")]
        public ActionResult MugalimBB()
        {
            ViewBag.Message = "Your";

            return View();
        }

        [Authorize(Roles = "Ata_ana")]
        public ActionResult Ata_anaBB()
        {
            ViewBag.Message = "Your";

            return View();
        }

        [Authorize(Roles = "Okushy")]
        public ActionResult OkushyBB()
        {
            Mektep_DBEntities db = new Mektep_DBEntities();
            Okushylar okushylar = db.Okushylar.SingleOrDefault(x => x.Id_okushy == 2001);
            OkushyViewModel OkushyVM = new OkushyViewModel();

            OkushyVM.Id_okushy = okushylar.Id_okushy;
            OkushyVM.Aty = okushylar.Aty;
            OkushyVM.Tegi = okushylar.Tegi;
            OkushyVM.Akesinin_aty = okushylar.Akesinin_aty;
            OkushyVM.Tugan_kuni = okushylar.Tugan_kuni;
            OkushyVM.Tel_nomeri = okushylar.Tel_nomeri;
            OkushyVM.Email = okushylar.Email;
            OkushyVM.Class = okushylar.Class;
            OkushyVM.Synyp_zhetekshisi = okushylar.Synyp_zhetekshisi;
            OkushyVM.Okushy_kosymsha_akparaty = okushylar.Okushy_kosymsha_akparaty;

            return View(OkushyVM);
        }

        [Authorize(Roles = "Meml_kyzmetker")]
        public ActionResult Meml_kyzmetkerBB()
        {
            ViewBag.Message = "Your";

            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            using (Mektep_DBEntities dc = new Mektep_DBEntities())
            {
                var events = dc.Events.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

    }
}