using ApressMvc.Models;
using ApressMvc.Repos;
using Microsoft.AspNetCore.Mvc;

namespace ApressMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepo)
        {
            _productRepository = productRepo;
        }

        public IActionResult Index()
        {

            return View(_productRepository.Product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productRepository.Add(product);
            return RedirectToAction(nameof(Index));
        }

    }
}
