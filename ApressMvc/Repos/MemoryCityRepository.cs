using ApressMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApressMvc.Repos
{
    public class MemoryCityRepository : ICityRepository
    {
        private List<City> _cities = new List<City>
        {
            new City
            {
                Name="Londn",
                Country = "UK",
                Population = 8539000
            },
            new City
            {
                Name = "New York",
                Country = "USA",
                Population = 8406000
            },
            new City
            {
                Name = "San Jose",
                Country = "USA",
                Population = 998537
            },
            new City
            {
                Name = "Paris",
                Country = "France",
                Population = 2244000
            }
        };

        public IEnumerable<City> Cities => _cities;

        public void Add(City city)
        {
            _cities.Add(city);
        }
    }
}
