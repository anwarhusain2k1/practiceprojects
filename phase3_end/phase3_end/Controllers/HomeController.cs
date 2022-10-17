using System.Diagnostics;
using DAL;
using Microsoft.AspNetCore.Mvc;
using phase3_end.Models;

namespace phase3_end.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
                la.ram = litem.ram;
                la.stock_available = Convert.ToInt32(litem.stock_available);
                l.Add(la);
            }
            return View(list);
        }
        public IActionResult Buy(int id)
        {
            operation op = new operation();
            laptop_list l = op.buy(id);
            return View(l);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}