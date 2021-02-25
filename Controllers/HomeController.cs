﻿using IS413_Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IS413_Assignment_5.Models.ViewModels;

namespace IS413_Assignment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStoreRepository _repository;
        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger, IStoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                    .OrderBy(p => p.ISBN)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
