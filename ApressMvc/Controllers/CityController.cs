using ApressMvc.Models;
using ApressMvc.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Collections.Generic;

namespace ApressMvc.Controllers
{
    [ViewComponent(Name = "Hybrid")]
    public class CityController : Controller
    {
        private ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;   
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(City city)
        {
            _cityRepository.Add(city);

            return RedirectToAction("Index", "Home"); 
        }

        public IViewComponentResult Invoke()
        {
            var res = new ViewViewComponentResult()
            {
                ViewData= new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<City>>(ViewData,_cityRepository.Cities)
            };

            return res;   
        }
    }
}
