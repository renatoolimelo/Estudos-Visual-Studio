using System;
using System.Collections.Generic;

namespace CadastroMoveis {
    class Program {

        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();
        public static List<ItemPedido> itensPedido = new List<ItemPedido>();

        static void Main(string[] args) {

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            int opcao = 0;

            while (opcao != 5) {
                Console.Clear();
                Tela.menu();
                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }

                switch (opcao) {

                    case 1:
                        Tela.listarProdutos();
                        break;

                    case 2:
                        try {
                            Tela.cadastrarProduto();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de négocio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;

                    case 3:
                        try {
                            Tela.cadastrarPedido();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de négocio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }

                        break;
                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Fim do programa!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
