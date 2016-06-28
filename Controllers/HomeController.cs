using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Data;
using WebApplication.Models.EF;
namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
         private readonly ILogger<HomeController> _logger;
        public HomeController(ApplicationDbContext db,ILogger<HomeController> logger)
        {
            _db = db;
            _logger =  logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("ssssssssssss");
           _db.Add(new ShopInfo()
           {
               Name="test111",
           }.SetDefault());
           _db.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
