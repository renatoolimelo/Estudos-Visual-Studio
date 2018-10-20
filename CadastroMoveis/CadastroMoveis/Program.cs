using System;
using System.Collections.Generic;

namespace CadastroMoveis {
    class Program {

        public static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args) {

            int opcao = 0;

            while(opcao != 5) {
                Console.Clear();
                Tela.menu();
                try {
                    opcao = int.Parse(Console.ReadLine());
                }catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
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
                        Console.WriteLine("Opção inválida: " + opcao);
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
