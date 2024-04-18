using EcommerceSite.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceSite.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult All()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(new ProductFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductFormModel product)
        {
            return View();
        }
    }
}
