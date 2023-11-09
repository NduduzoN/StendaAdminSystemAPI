using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StendaAdminSystemAPI.Controllers
{
    public class BankingDetailsController : Controller
    {
        // GET: BankingDetailsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BankingDetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankingDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankingDetailsController/Create
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

        // GET: BankingDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankingDetailsController/Edit/5
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

        // GET: BankingDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankingDetailsController/Delete/5
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
