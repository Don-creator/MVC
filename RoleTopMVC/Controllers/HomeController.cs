using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTOP.Models;
using RoleTopMVC.ViewModels;

namespace RoleTOP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {   ViewData["Action"] = "Home";
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}


