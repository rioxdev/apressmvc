using ApressMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApressMvc.Repos
{
    public interface IProductRepository
    {
        IEnumerable<Product> Product { get; }

        void Add(Product product);
    }
}
