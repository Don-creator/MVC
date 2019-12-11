using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;

namespace RoleTopMVC.Repositories {
    public class PedidoRepository : RepositoryBase {
        private const string PATH = "Database/Servicos.csv";
        public PedidoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }

        }
        public bool Inserir (Servicos pedido) {
            var quantidadePedidos = File.ReadAllLines (PATH).Length; //Tradução PATH: Caminho - Para mostra o caminho do arquivo e Length: Para pegar o tamanho do Vetor
            pedido.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] { PrepararPedidoCSV (pedido) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Servicos> ObterTodosPorCliente (string emailCliente) {
            var pedidos = ObterTodos ();
            List<Servicos> pedidoCliente = new List<Servicos> ();

            foreach (var pedido in pedidos) {
                if (pedido.Cliente.Email.Equals (emailCliente)) {
                    pedidoCliente.Add (pedido);
                }
            }
            return pedidoCliente;
        }

        public List<Servicos> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Servicos> pedidos = new List<Servicos> ();
            foreach (var linha in linhas) {
                Servicos pedido = new Servicos ();
                // Cliente c = new Cliente ();

                pedido.Id = ulong.Parse (ExtrairValorDoCampo ("id", linha));
                pedido.Status = uint.Parse(ExtrairValorDoCampo ("status_pedido", linha));
                pedido.Cliente.Nome = ExtrairValorDoCampo ("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo ("cliente_endereco", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo ("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo ("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse (ExtrairValorDoCampo ("hamburguer_preco", linha));
                pedido.Shake.Nome = (ExtrairValorDoCampo ("shake_nome", linha));
                pedido.Shake.Preco = double.Parse (ExtrairValorDoCampo ("shake_preco", linha));
                pedido.PrecoTotal = double.Parse (ExtrairValorDoCampo ("preco_total", linha));
                pedido.DataDoPedido = DateTime.Parse (ExtrairValorDoCampo ("data_pedido", linha));

                pedidos.Add (pedido);
            }
            return pedidos;
        }
        public Servicos ObterPor(ulong id)
        {
            var pedidosTotais = ObterTodos();
            foreach (var pedido in pedidosTotais)
            {
                if (id.Equals(pedido.Id))
                {
                    return pedido;
                }
            }
            return null;
        }

        public bool Atualizar(Servicos pedido)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidosCSV = PrepararPedidoCSV(pedido);
            var linhasPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", pedidosTotais[i]));
                if (pedido.Id.Equals(idConvertido))
                {
                    linhasPedido = i;
                    resultado = true;
                    break;
                }
            }
                if(resultado)
                {
                    pedidosTotais[linhasPedido] = pedidosCSV;
                    File.WriteAllLines(PATH, pedidosTotais);
                }
                return resultado;
        }

        private new string ExtrairValorDoCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf (chave);

            var indiceTerminal = linha.IndexOf (";", indiceChave);

            var valor = "";

            if (indiceTerminal != -1) {
                valor = linha.Substring (indiceChave, indiceTerminal - indiceChave);
            } else {
                valor = linha.Substring (indiceChave);
            }
            System.Console.WriteLine ($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace (nomeCampo + "=", " ");
        }

        private string PrepararPedidoCSV (Servicos pedido) {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"id = {pedido.Id};status_pedido={pedido.Status};cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}";
        }
    }
}