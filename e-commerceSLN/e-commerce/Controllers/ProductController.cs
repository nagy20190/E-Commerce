﻿using e_commerce.Contexts;
using e_commerce.Models;
using e_commerce.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        // Dependency Injection
        IproductRepository productRepository;
        public ProductController(IproductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public IActionResult Index()
        {
            return View("Index", productRepository.GetAll());
        }

        

    }
}
