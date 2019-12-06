using System;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController {

        ClienteRepository clienteRepositorio = new ClienteRepository ();

        public IActionResult Index () {
            ViewData ["navCadastro"] = "Cadastro";
            return View (new BaseViewModel () {
                NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession (),
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            ViewData["navDeuBom"]="NavDeuBom";
            try {
                Cliente cliente = new Cliente (
                    form["nome"],
                    form["endereco"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse (form["data-nascimento"])
                );

                cliente.TipoUsuario = (uint) TipoUsuario.CLIENTE;
                clienteRepositorio.Inserir (cliente);


                return View ("Sucesso", new RespostaViewModel () {
                        NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel ("Mensagem"));
            }
        }
    }
}