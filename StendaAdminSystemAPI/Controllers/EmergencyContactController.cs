using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StendaAdminSystemAPI.Controllers
{
    public class EmergencyContactController : Controller
    {
        // GET: EmergencyContactController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmergencyContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmergencyContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmergencyContactController/Create
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

        // GET: EmergencyContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmergencyContactController/Edit/5
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

        // GET: EmergencyContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmergencyContactController/Delete/5
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
