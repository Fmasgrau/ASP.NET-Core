using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacundoMasgrau.Models;
using FacundoMasgrau.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacundoMasgrau.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMundialRepository _mundialRepository;

        public HomeController(IMundialRepository mundialRepository)
        {
            _mundialRepository = mundialRepository;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            

            var mundiales = _mundialRepository.GetAllMundials().OrderBy(m => m.Id);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Viví el mundial acá",
                Mundiales = mundiales.ToList()
            };

            return View(homeViewModel);
        }
    }
}
