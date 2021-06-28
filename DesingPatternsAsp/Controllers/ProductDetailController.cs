using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesingPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            // Factory
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            ForeingEarnFactory foreingEarnFactory = new ForeingEarnFactory(0.30m, 20);

            // Products
            var localEarn = localEarnFactory.GetEarn();
            var foreingEarn = foreingEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeing = total + foreingEarn.Earn(total);


            return View();
        }
    }
}
