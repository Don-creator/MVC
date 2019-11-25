using System.Collections.Generic;
using McBonaldsMVC.Models;
using MCBonaldsMVC.ViewModels;

namespace McBonaldsMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shake{get;set;}

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>();
            this.Shake = new List<Shake>();
        }

    }
}