using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StendaAdminSystemAPI.Controllers
{
    public class LicenceController : Controller
    {
        // GET: LicenceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LicenceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LicenceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LicenceController/Create
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

        // GET: LicenceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LicenceController/Edit/5
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

        // GET: LicenceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LicenceController/Delete/5
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
