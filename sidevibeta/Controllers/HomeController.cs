using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sidevibeta.Models;

namespace sidevibeta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modifique esta plantilla para poner en marcha su aplicación ASP.NET MVC.";

            return View();
        }

        public String consulta() {
        
           mdlprueba prueba = new mdlprueba();
           return  prueba.consulta();
        
        }




    }
}
