using ApressMvc.Repos;
using System.Linq;

namespace ApressMvc.Components
{
    public class PocoViewComponent
    {
        private readonly ICityRepository _cityRepository;
        public PocoViewComponent(ICityRepository cityRepo)
        {
            _cityRepository = cityRepo;
        }

        public string Invoke() => $"{_cityRepository.Cities.Count()} cities, {_cityRepository.Cities.Sum(c => c.Population)} people";
    }
}