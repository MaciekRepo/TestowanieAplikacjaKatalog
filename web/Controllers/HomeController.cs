using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using web.Models.AppViewModels;
using Microsoft.AspNetCore.Mvc;
using web.Models;
using AutoMapper;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        public IActionResult Controls1()
        {
            var author = new AuthorViewModel();
            author.Created = DateTime.Now - TimeSpan.FromDays(2);
            author.Modified = DateTime.Now;
            return View(Mapper.Map<AuthorViewModel>(author));
        }

        public IActionResult Controls2()
        {
            return View(ComponentViewModel.GetComponentsViewModelsList());
        }

        public IActionResult con(string name)
        {
            return View(name);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
