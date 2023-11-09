using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StendaAdminSystemAPI.Controllers
{
    public class MedicalController : Controller
    {
        // GET: MedicalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalController/Create
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

        // GET: MedicalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicalController/Edit/5
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

        // GET: MedicalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalController/Delete/5
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
