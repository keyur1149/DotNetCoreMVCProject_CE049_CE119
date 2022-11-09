using Microsoft.AspNetCore.Mvc;
using OnlineGift.Data.Services;
using OnlineGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProduct =await  _service.GetAllAsync();
            return View(allProduct);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Desc,ImgUrl,Prize")]Product product)
        {
            if(!ModelState.IsValid)
            {
                return View(product);
            }
            await _service.AddAsync(product);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Details(int id)
        {
            var p =await _service.GetByIdAsync(id);
            if (p == null) return View("404 not found");
            return View(p);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            var response = new Product()
            {
                Id = productDetails.Id,
                Name = productDetails.Name,
                Desc = productDetails.Desc,
                Prize = productDetails.Prize,
                ImgUrl = productDetails.ImgUrl,
        
            };
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            await _service.UpdateProductAsync(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            return View(productDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> Deleteconfirmed(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            await _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
