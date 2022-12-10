using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCondominio.Controllers
{
    public class CondominoController : Controller
    {
        // GET: CondominoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CondominoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CondominoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CondominoController/Create
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

        // GET: CondominoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CondominoController/Edit/5
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

        // GET: CondominoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CondominoController/Delete/5
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
