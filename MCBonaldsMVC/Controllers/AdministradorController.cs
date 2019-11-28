using McBonaldsMVC.Controllers;
using McBonaldsMVC.Repositories;
using MCBonaldsMVC.Enums;
using MCBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MCBonaldsMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        public IActionResult Dashboard()
        {
            var pedido = pedidoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            foreach (var pedidos in pedido)
            {
                switch (pedidos.Status)
                {
                    case (uint)StatusPedido.APROVADO:
                        dashboardViewModel.PedidosAprovados++;
                    break;
                    case (uint)StatusPedido.REPROVADO:
                        dashboardViewModel.PedidosReprovados++;
                    break;
                    default:
                    case (uint)StatusPedido.PENDENTE:
                        dashboardViewModel.PedidosPendentes++;
                        dashboardViewModel.Pedidos.Add(pedidos);
                    break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();

            return View(dashboardViewModel);
        }
    }
}