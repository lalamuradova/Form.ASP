using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Task2.Entity;
using Task2.Fakerepo;
using Task2.Helpers;
using Task2.Model;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private  PersonListViewModel _vm;
        private readonly IWebHostEnvironment _webhost;
        public HomeController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
            _vm = new PersonListViewModel
            {
                Persons=FakeRepo.Persons
            };
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_vm);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Person person)
        {
            ImageHelper imageHelper = new ImageHelper(_webhost);

            person.ImageUrl = imageHelper.SaveFile(person.File);
            FakeRepo.Persons.Add(person);
            return RedirectToAction("Index");
        }
    }
}
