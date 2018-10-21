using System;
using System.Globalization;

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

        public static void cadastrarArtista() {
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Program.artistas.Add(new Artista(codigo, nome, cache));
            Console.WriteLine("Cadastrado com sucesso");
            Program.artistas.Sort();
        }

        public static void listarArtista() {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for(int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i]);
            }
            Console.WriteLine("Fim da lista");
        }
    }
}
