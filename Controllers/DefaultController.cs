using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResume.Models.Entity;


namespace MvcResume.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        ResumeDbEntities db = new ResumeDbEntities();
        public ActionResult Index()
        {
            var AboutList = db.TblAbouts.ToList();
            return View(AboutList);
        }
    }
}