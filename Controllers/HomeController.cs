using Microsoft.AspNetCore.Mvc;
using MysticBureau.Interfaces;
using MysticBureau.Models;
using MysticBureau.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MysticBureau.Controllers
{
    public class HomeController : Controller
    {
        private IAllFacts _factRep;

        public HomeController(IAllFacts factRep)
        {
            _factRep = factRep;
        }

        public ViewResult Index()
        {
            var homeFacts = new FactListViewModel
            {
                AllFacts = _factRep.Facts
            };
            return View(homeFacts);
        }

    }
}
