using ConsumirApiFarmacia.Models;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumirApiFarmacia.Controllers
{
    public class HomeController : Controller
    {

        AdministradorFarmacia administradorFarmacia = new AdministradorFarmacia();

        public ActionResult Index()
        {

            List<Farmacia> listaFarmacia = administradorFarmacia.ObtenerTodos();

            return View(listaFarmacia);
        }

        // GET: Default/Details/5
        public ActionResult Details(string id)
        {
            Farmacia farmacia = administradorFarmacia.ObtenerFarmacia(id);

            return View(farmacia);
        }

        
        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(BusquedaComuna busquedaComuna)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            List<Farmacia> listaFarmacia = administradorFarmacia.BuscarPorComuna(busquedaComuna.nombreComuna);

            return View("Index",listaFarmacia);
        }





    }
}