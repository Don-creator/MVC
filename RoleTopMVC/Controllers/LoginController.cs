using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}