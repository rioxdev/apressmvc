using ApressMvc.Models;
using ApressMvc.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApressMvc.Components
{
    public class CitySummary : ViewComponent
    {
        private readonly ICityRepository _cityRepo;

        public CitySummary(ICityRepository cityRepo)
        {
            _cityRepo = cityRepo;   
        }
        public IViewComponentResult Invoke()
        {
            return View(new CityViewmodel
            {
                Cities = _cityRepo.Cities.Count(),
                Population = _cityRepo.Cities.Sum(c=> c.Population)
            }) ;
        }
    }
}
