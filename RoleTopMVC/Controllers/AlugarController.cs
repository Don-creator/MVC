using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AlugarController : AbstractController
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult CadastrarEvento()
        {
            return View();
        }
    }
}