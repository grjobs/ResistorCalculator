using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicColorCodeCalculator.Entities;

namespace ElectronicColorCodeCalculator.Controllers
{
    public class OhmCalculatorController : Controller
    {
        //
        // GET: /OhmCalculator/

        public ActionResult Index()
        {
            return View("OhmCalculator");
        }

        public ActionResult SubmitNew(string bandA, string bandB, string bandC, string bandD)
        {
            OhmValueCalculator o = new OhmValueCalculator();
           int val= o.CalculateOhmValue(bandA,bandB,bandC,bandD); 

          //  return Json(val.ToString());
           return Content(val.ToString());
        }

    }
}
