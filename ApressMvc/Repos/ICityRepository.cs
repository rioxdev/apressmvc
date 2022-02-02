using ApressMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApressMvc.Repos
{
    public interface ICityRepository
    {
        IEnumerable<City> Cities { get; }

        void Add(City city);
    }
}
