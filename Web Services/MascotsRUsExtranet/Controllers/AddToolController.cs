using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MascotsRUsExtranet.Controllers
{
    public class AddRentalItemController : Controller
    {
        // GET: AddRentalItem
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Models.RentalItem rentalItem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ViewBag.Message = "Your rental item has been added!";
                    return View();
                }
                catch (System.Web.Services.Protocols.SoapException ex)
                {
                    ModelState.AddModelError(String.Empty, ex.Message);
                    return View("Index", rentalItem);
                }
            }
            else
            {
                return View("Index", rentalItem);
            }
        }
    }
}