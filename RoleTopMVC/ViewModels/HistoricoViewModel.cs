using System.Collections.Generic;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Servicos> Pedidos {get;set;}
    }
}