using System;

namespace CadastroFilme {
    class Program {
        static void Main(string[] args) {

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
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Fim do programa!");
                        break;

                    default:
                        Console.WriteLine("opcao inválida");
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
