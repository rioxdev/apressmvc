using ApressMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApressMvc.Repos
{
    public class MemoryProductRepository : IProductRepository
    {
        private List<Product> _product = new List<Product>
        {
            new Product
            {
                Name = "Galaxy S22",
                Price = 1250M
            },
            new Product
            {
                Name = "Logitech G720",
                Price = 88
            },
            new Product
            {
                Name = "MSI Godlike gaming",
                Price  = 499
            }
        };

        public IEnumerable<Product> Product => _product;

        public void Add(Product product)
        {
            _product.Add(product);
        }
    }
}
