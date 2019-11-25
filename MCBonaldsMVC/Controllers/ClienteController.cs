using System;
using McBonaldsMVC.Repositories;
using MCBonaldsMVC.Repositories;
using MCBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : RepositoryBase
    {
        private const string SESSION_CLIENTE_EMAIL = "cliente_email";
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioNomeSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
            });
            
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("==================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("==================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)
                {   
                    HttpContext.Session.SetString("SESSION_CLIENTE_EMAIL", usuario);
                    if (cliente.Senha.Equals(senha))
                    {
                        return RedirectToAction("Historico","Cliente");
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }

                return View("Sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }

        public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidosCliente
            });
        }
    }
}