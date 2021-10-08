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
        private EarnFactory _localEarnFactory;
        private ForeignEearnFactory _foreignEearnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEearnFactory foreignEearnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEearnFactory= foreignEearnFactory;

        }
        public IActionResult Index(decimal total)
        {
            
            //products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEearnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + localEarn.Eearn(total);
            ViewBag.totalForeign = total + foreignEarn.Eearn(total);

            return View();
        }
    }
}
