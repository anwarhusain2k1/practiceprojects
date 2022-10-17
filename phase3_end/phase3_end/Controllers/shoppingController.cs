using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using phase3_end.Models;

namespace phase3_end.Controllers
{
    public class shoppingController : Controller
    {
        // GET: shoppingController
        public ActionResult Index()
        {
            operation op = new operation();
            List<laptop_list> list = op.get();
            List<laptop> l = new List<laptop>();
            foreach (var litem in list)
            {
                laptop la = new laptop();
                la.laptopid = litem.laptopid;
                la.brand = litem.brand;
                la.processor = litem.processor;
                la.ram= litem.ram;
                la.stock_available = Convert.ToInt32 (litem.stock_available);
                l.Add(la);
            }
            return View(list);
        }

        // GET: shoppingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: shoppingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: shoppingController/Create
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

        // GET: shoppingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: shoppingController/Edit/5
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

        // GET: shoppingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: shoppingController/Delete/5
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
