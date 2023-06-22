using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SocioController : Controller
    {
        // GET: SocioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SocioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ReservaActividad()
        {
            return View();
        }
       
    }
}
