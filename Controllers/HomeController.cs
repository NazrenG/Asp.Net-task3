using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication4.Entities;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IWebHostEnvironment _env;


        public HomeController(IProductService productService, IHttpClientFactory clientFactory, IWebHostEnvironment env)
        {
            _clientFactory = clientFactory;
            _env = env; _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            var item = new ProductListViewModel
            {
                Products = products
            };
            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _productService.GetProductById(id);
            if (item == null)
            {
                return NotFound();
            }
            await _productService.DeleteAsync(item);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            var item = new ProductAddViewModel
            {
                Product = new Product()
            };
            return View(item);
        }



        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(vm.ImageUrl))
                {
                    var client = _clientFactory.CreateClient();
                    var response = await client.GetAsync(vm.ImageUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var imageBytes = await response.Content.ReadAsByteArrayAsync();
                        var imageName = Path.GetFileName(new Uri(vm.ImageUrl).AbsolutePath);
                        var imagePath = Path.Combine(_env.WebRootPath, "images", imageName);

                        await System.IO.File.WriteAllBytesAsync(imagePath, imageBytes);

                        vm.Product.ImagePath = $"/images/{imageName}";

                        await _productService.AddAsync(vm.Product);
                        var products = await _productService.GetAllProductsAsync();
                        products.Add(vm.Product);
                    }
                }



                return RedirectToAction("Index");
            }

            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var item = await _productService.GetProductById(id);
            if (item == null)
            {
                return NotFound();
            }

            var updateProduct = new ProductUpdateViewModel
            {
                Product = new Product
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Description = item.Description,
                    ImagePath = item.ImagePath,
                    Discount = item.Discount
                }
            };
            return View(updateProduct);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateViewModel vm, int id)
        {
            var item = await _productService.GetProductById(id);
            if (ModelState.IsValid)
            {
                if (item != null)
                {
                    item.Name = vm.Product.Name;
                    item.Price = vm.Product.Price;
                    item.Description = vm.Product.Description;
                    item.ImagePath =  vm.Product.ImagePath;
                    item.Discount = vm.Product.Discount;  
                    
                    await _productService.UpdateAsync(item);
              
                    return RedirectToAction("Index"); 
                  
                }


            }
            return View(vm);

        }
    }
}