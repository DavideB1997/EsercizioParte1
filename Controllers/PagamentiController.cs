using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioParte1.Controllers
{
    public class PagamentiController : Controller
    {
        // GET: PagamentiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PagamentiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PagamentiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PagamentiController/Create
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

        // GET: PagamentiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagamentiController/Edit/5
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

        // GET: PagamentiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PagamentiController/Delete/5
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
