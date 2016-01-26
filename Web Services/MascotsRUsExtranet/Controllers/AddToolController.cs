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
                    AddRentalItemToAcumatica(rentalItem.RentalItemCode, rentalItem.Description, rentalItem.Cost, rentalItem.SerialNumber);
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

        private void AddRentalItemToAcumatica(string rentalItemCode, string description, decimal cost, string serialNumber)
        {
            var rentalItemManagement = new RP301000.Screen();
            rentalItemManagement.CookieContainer = new System.Net.CookieContainer();
            rentalItemManagement.Login("admin", "admin");

            var schema = rentalItemManagement.GetSchema();

            var commands = new RP301000.Command[] {
                new RP301000.Value() { LinkedCommand = schema.Items.RentalItemCode, Value = rentalItemCode },
                new RP301000.Value() { LinkedCommand = schema.Items.Description, Value = description },
                new RP301000.Value() { LinkedCommand = schema.Items.Cost, Value = cost.ToString(System.Globalization.CultureInfo.InvariantCulture) },
                new RP301000.Value() { LinkedCommand = schema.Items.SerialNumber, Value = serialNumber },
                schema.Actions.Save
            };

            rentalItemManagement.Submit(commands);
        }
    }
}