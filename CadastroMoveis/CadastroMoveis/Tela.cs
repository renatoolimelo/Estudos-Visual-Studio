using System;
using System.Globalization;

namespace CadastroMoveis {
    class Tela {
        public static void menu() {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("1 – Listar produtos ordenadamente");
            Console.WriteLine("2 – Cadastrar produto");
            Console.WriteLine("3 – Cadastrar pedido");
            Console.WriteLine("4 – Mostrar dados de um pedido");
            Console.WriteLine("5 – Sair");
            Console.WriteLine();
        }

        public static void listarProdutos() {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for (int i = 0; i < Program.produtos.Count; i++) {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto() {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.produtos.FindIndex(x => x.codigo == codigo);
            if (pos != -1) {
                throw new ModelException("Código do produto já cadastrado: " + codigo);
            }
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Program.produtos.Add(new Produto(codigo, descricao, preco));
            Program.produtos.Sort();
        }

        public static void cadastrarPedido() {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigoPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codigoPedido);
            if (pos != -1) {
                throw new ModelException("Código do pedido já cadastrado: " + codigoPedido);
            }
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Program.pedidos.Add(new Pedido(codigoPedido, dia, mes, ano));
            Console.Write("Quantos itens tem o pedido: ");
            int quantidadeItens = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeItens; i++) {
                Console.WriteLine("Digite os dados do " + (i + 1) + "º item:");
                Console.Write("Produto (código): ");
                int codigoProduto = int.Parse(Console.ReadLine());
                int posicaoProduto = Program.produtos.FindIndex(x => x.codigo == codigoProduto);
                if (posicaoProduto == -1) {
                    throw new ModelException("Produto não cadastrado: " + codigoProduto);
                }
                Console.Write("Quantidade: ");
                int quantidadeProdutos = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcentagemDesconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Program.itensPedido.Add(new ItemPedido(codigoProduto, codigoPedido, quantidadeProdutos, porcentagemDesconto));
            }
        }

        public static void mostrarPedido() {
            Console.Write("Digite o código do pedido: ");
            int codigoPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codigoPedido);
            if (pos == -1) {
                throw new ModelException("Codigo não possui pedido cadastrado " + codigoPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine("Itens: ");
            for (int i = 0; i < Program.itensPedido.Count; i++) {
                if (Program.pedidos[pos].codigo == Program.itensPedido[i].codigoPedido) {
                    for (int j = 0; j < Program.produtos.Count; j++) {
                        if (Program.itensPedido[i].codigoProduto == Program.produtos[j].codigo) {
                            Console.Write(Program.produtos[j].descricao
                                + ", Preço: "
                                + Program.produtos[j].preco);
                        }
                    }
                    Console.WriteLine(Program.itensPedido[i]);
                }
            }

        }

    }
}
