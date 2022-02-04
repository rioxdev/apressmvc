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
            return View("Completed", model);
        }
    }
}
