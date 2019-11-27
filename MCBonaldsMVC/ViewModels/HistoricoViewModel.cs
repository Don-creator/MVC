using System.Collections.Generic;
using McBonaldsMVC.Models;
using MCBonaldsMVC.ViewModels;

namespace McBonaldsMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
    }
}