using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCondominio.Controllers
{
    public class RootController : Controller
    {
        // GET: RootController
        public ActionResult RIndex()
        {
            return View();
        }

        // GET: RootController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RootController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RootController/Create
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

        // GET: RootController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RootController/Edit/5
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

        // GET: RootController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RootController/Delete/5
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
