using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCondominio.Controllers
{
    public class OfiSeguridadController : Controller
    {
        // GET: OfiSeguridadController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: OfiSeguridadController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OfiSeguridadController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfiSeguridadController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: OfiSeguridadController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OfiSeguridadController1/Edit/5
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

        // GET: OfiSeguridadController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OfiSeguridadController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
