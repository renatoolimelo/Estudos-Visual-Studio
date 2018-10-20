using System;

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

    }
}
