using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //factories
            LocalEarnFactory localEarnFactory=new LocalEarnFactory(0.20m);
            ForeignEearnFactory foreignEearnFactory=new ForeignEearnFactory(0.30m, 20);

            //products
            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEearnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + localEarn.Eearn(total);
            ViewBag.totalForeign = total + foreignEarn.Eearn(total);

            return View();
        }
    }
}
