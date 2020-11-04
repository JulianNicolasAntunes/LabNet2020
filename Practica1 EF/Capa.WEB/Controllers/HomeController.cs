using Capa.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Capa.WEB.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities contexto = null;
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Categorias";
            contexto = new NorthwindEntities();
            List<Categories> categorias = contexto.Categories.ToList();
           
            return View(categorias);
        }
       


        public ActionResult Contact()
        {
            ViewBag.Message = "Territorios";
            contexto = new NorthwindEntities();
            List<Territories> territorios = contexto.Territories.ToList();

            return View(territorios);
        }
    }
}