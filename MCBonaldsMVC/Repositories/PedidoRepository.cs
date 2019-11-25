using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;
using MCBonaldsMVC.Repositories;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }
        public bool Inserir(Pedido pedido)
        {
            var linha = new string[] { PrepararPedidoCSV(pedido) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos();
            List<Pedido> pedidoCliente = new List<Pedido>();
            
            foreach (var pedido in pedidos)
            {
                if (pedidos.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }
        

        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();
                Cliente c = new Cliente();
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo("cliente_endereco", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_preco",linha));
                pedido.Shake.Nome = (ExtrairValorDoCampo("shake_nome", linha));
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_preco", linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));

                pedidos.Add(pedido);
            }
            return pedidos;
        }

        private string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);

            var indiceTerminal = linha.IndexOf(";", indiceChave);

            var valor = "";

            if (indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=", " ");
        }

        private string PrepararPedidoCSV(Pedido pedido)
        {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}";
        }
    }
}