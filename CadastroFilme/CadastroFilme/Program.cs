﻿using System;
using System.Collections.Generic;

namespace CadastroFilme {
    class Program {

        public static List<Artista> artistas = new List<Artista>();

        static void Main(string[] args) {

            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

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
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
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
