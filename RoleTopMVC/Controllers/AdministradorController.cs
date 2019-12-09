using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Enums;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();
        public IActionResult Dashboard () {
            
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioNomeSession());
            if (!ninguemLogado && (uint) TipoUsuario.ADMINISTRADOR == uint.Parse (ObterUsuarioTipoSession ())) {

                var pedido = pedidoRepository.ObterTodos ();
                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var pedidos in pedido) {
                    switch (pedidos.Status) {
                        case (uint) StatusPedido.APROVADO:
                            dashboardViewModel.PedidosAprovados++;
                            break;
                        case (uint) StatusPedido.REPROVADO:
                            dashboardViewModel.PedidosReprovados++;
                            break;
                        default:
                        case (uint) StatusPedido.PENDENTE:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel.Pedidos.Add (pedidos);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            } else {
                return View ("Erro", new RespostaViewModel () {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });
            }
        }
    }
}