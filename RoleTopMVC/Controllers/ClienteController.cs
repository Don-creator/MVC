using System;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController {
        private ClienteRepository clienteRepository = new ClienteRepository ();
        private PedidoRepository pedidoRepository = new PedidoRepository ();

        [HttpGet]
        public IActionResult Login () {
            
            ViewData ["NavView"] = "NavView";
            return View (new BaseViewModel () {
                    NomeView = "Login",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
            });
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            ViewData["Action"] = "Login";
            try {
                System.Console.WriteLine ("====================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                System.Console.WriteLine ("====================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor (usuario);

                if (cliente != null) {
                    if (cliente.Senha.Equals (senha)) {
                        switch (cliente.TipoUsuario) {
                            case (uint) TipoUsuario.CLIENTE:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.TipoUsuario.ToString ());

                                return RedirectToAction ("Historico", "Cliente");

                            default:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.TipoUsuario.ToString ());

                                return RedirectToAction ("Dashboard", "Administrador");
                        }
                    } else {
                        return View ("Erro", new RespostaViewModel ("Senha incorreta"));
                    }
                } else {
                    return View ("Erro", new RespostaViewModel ($"Usuário {usuario} não foi encontrado"));
                }
            } catch (Exception e) {
                System.Console.WriteLine ("====================");
                System.Console.WriteLine (e.StackTrace);
                System.Console.WriteLine ("====================");
                return View ("Erro", new RespostaViewModel("Erro"));
            }
        }

        public IActionResult Historico () {
            var emailCliente = HttpContext.Session.GetString (SESSION_CLIENTE_EMAIL);
            var pedidos = pedidoRepository.ObterTodosPorCliente (emailCliente);

            return View (new HistoricoViewModel () {
                Pedidos = pedidos,
                    NomeView = "Historico",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession (),
            });
        }
        public IActionResult Logoff () {
            HttpContext.Session.Remove (SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove (SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
    }
}