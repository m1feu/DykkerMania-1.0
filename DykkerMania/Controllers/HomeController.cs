using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DmRepo;

namespace DykkerMania.Controllers
{
    public class HomeController : Controller
    {
        GmapFac gf = new GmapFac();
        // GET: Home
        public ActionResult Index()
        {
            return View(gf.GetAll());
        }


        public ActionResult Opretpunkt()
        {
            return View();
        }
    }
}