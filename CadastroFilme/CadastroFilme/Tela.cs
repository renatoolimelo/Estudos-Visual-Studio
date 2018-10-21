using System;

namespace CadastroFilme {
    class Tela {

        public static void menu() {
            Console.WriteLine("-------------------Menu-------------------");
            Console.WriteLine("1 – Listar artistas");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
            Console.WriteLine("5 – Sair");
            Console.WriteLine("");
            Console.Write("Escolha uma opção: ");
        }
    }
}
