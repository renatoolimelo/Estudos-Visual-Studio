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
            for(int i = 0; i < Program.produtos.Count; i++) {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto() {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.produtos.FindIndex(x => x.codigo == codigo);
            if(pos != -1) {
                throw new ModelException("Código do produto já cadastrado: " + codigo);
            }
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Program.produtos.Add(new Produto(codigo, descricao, preco));
            Program.produtos.Sort();
        }

    }
}
