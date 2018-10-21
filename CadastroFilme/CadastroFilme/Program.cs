using System;
using System.Collections.Generic;

namespace CadastroFilme {
    class Program {

        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();
        public static List<Participacao> participacoes = new List<Participacao>();

        static void Main(string[] args) {

            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

            filmes.Add(new Filme(1010, "Lucy", 2014));
            filmes.Add(new Filme(2020, "Matrix", 2020));

            participacoes.Add(new Participacao(500000.00, 1010, 101));
            participacoes.Add(new Participacao(300000.00, 1010, 104));

            participacoes.Add(new Participacao(400000.00, 2020, 102));
            participacoes.Add(new Participacao(200000.00, 2020, 103));

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
                        Tela.listarArtista();
                        break;

                    case 2:
                        try {
                            Tela.cadastrarArtista();
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
                            Tela.cadastrarFilme();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de négocio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;

                    case 4:
                        try {
                            Tela.mostrarFilme();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de négocio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
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
