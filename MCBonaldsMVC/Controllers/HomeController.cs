using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MCBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
            NomeView = "Home",
            UsuarioEmail = ObterUsuarioNomeSession(),
            UsuarioNome = ObterUsuarioNomeSession(),
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
