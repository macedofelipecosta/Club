using LogicaConexion.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: AdministradorController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AltaSocio()
        {
            

            return RedirectToAction("Index", "Home");
        }





    }
}
