using InfluPro.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace InfluPro.UI.Controllers
{
    public class ProfileTypeController : Controller
    {
        private readonly IProfileTypes _profileType;
        public ProfileTypeController(IProfileTypes profileType)
        {
           _profileType = profileType;
        }

        // GET: ProfileType
        public ActionResult Index()
        {
            return View(_profileType.Getlist());
        }

        // GET: ProfileType/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfileType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfileType/Create
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

        // GET: ProfileType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfileType/Edit/5
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

        // GET: ProfileType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileType/Delete/5
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
