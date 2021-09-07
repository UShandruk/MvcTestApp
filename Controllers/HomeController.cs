using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcTestApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Начальная страница
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<Customer> listCustomer = DAL.GetCustomers();
            return View(listCustomer);
        }



        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult Create(Person person)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        DAL.Persons.Add(person);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(person);
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
