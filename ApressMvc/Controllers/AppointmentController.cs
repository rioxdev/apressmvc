using ApressMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApressMvc.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View("Create", new Appointment { Date = DateTime.Now });
        }

        [HttpPost]
        public IActionResult MakeBooking(Appointment model)
        {

            if (String.IsNullOrEmpty(model.ClientName))
            {
                ModelState.AddModelError(nameof(model.ClientName), "Please enter your name");
            }

            if (ModelState.GetValidationState("Date") == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Valid
                && DateTime.Now > model.Date)
            {
                ModelState.AddModelError(nameof(model.Date), "Please enter a date in the future");
            }

            if (!model.TemrsAccepted)
            {
                ModelState.AddModelError(nameof(model.TemrsAccepted), "You must accept the terms");
            }


            if (ModelState.IsValid)
               return  View("Completed", model);
            else
               return  RedirectToAction("Index");
        }
    }
}
