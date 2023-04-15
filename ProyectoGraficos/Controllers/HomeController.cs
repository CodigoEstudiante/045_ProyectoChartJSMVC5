using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;





//************ IMPORTANTE AÑADIR ESTAS REFERENCIAS ******************************
using ProyectoGraficos.Datos;
using ProyectoGraficos.Models;


namespace ProyectoGraficos.Controllers
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

        [HttpGet]
        public JsonResult ReporteVentas()
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<ReporteVenta> objLista = objDT_Reporte.RetornarVentas();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public JsonResult ReporteProductos()
        {
            DT_Reporte objDT_Reporte = new DT_Reporte();

            List<ReporteProducto> objLista = objDT_Reporte.RetornarProductos();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }


    }
}