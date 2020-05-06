using AfpaTinderMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfpaTinderMvc.Controllers
{
    public class HomeController : Controller
    {
        AfpaTinderContext afpaTinderContext = new AfpaTinderContext();
        public ActionResult Index()
        {
            afpaTinderContext.Personnes.Add(new Personne { Nom = "toto", Prenom = "titi", Email = "dfd", Login = "aa", Password = "test", Status = true});

            afpaTinderContext.SaveChanges();
            
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
    }
}