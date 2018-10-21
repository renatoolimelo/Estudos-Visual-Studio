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
            int pos = Program.artistas.FindIndex(x => x.codigo == codigo);
            if (pos != -1) {
                throw new ModelException("Codigo já está cadastrado: " + codigo);
            }
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
            for (int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i]);
            }
            Console.WriteLine("Fim da lista");
        }

        public static void cadastrarFilme() {
            Console.WriteLine("Digite os dados do filme: ");
            Console.Write("Código: ");
            int codigoFilme = int.Parse(Console.ReadLine());
            int posFilme = Program.filmes.FindIndex(x => x.codigo == codigoFilme);
            if (posFilme != -1) {
                throw new ModelException("Código já está cadastrado: " + codigoFilme);
            }
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Quantas participações tem o filme: ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] codigoArtista = new int[quantidade];
            double[] desconto = new double[quantidade];
            for (int i = 0; i < quantidade; i++) {
                Console.WriteLine("Digite os dados da " + (i + 1) + "ª participação:");
                Console.Write("Artista (código): ");
                codigoArtista[i] = int.Parse(Console.ReadLine());
                int posArtista = Program.artistas.FindIndex(x => x.codigo == codigoArtista[i]);
                if (posArtista == -1) {
                    throw new ModelException("Artista não consta no cadastro: " + codigoArtista[i]);
                }
                Console.Write("Desconto: ");
                desconto[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Program.filmes.Add(new Filme(codigoFilme, titulo, ano));
            for (int i = 0; i < quantidade; i++) {
                Program.participacoes.Add(new Participacao(desconto[i], codigoFilme, codigoArtista[i]));
            }
            Console.WriteLine("Cadastrado com sucesso");
        }

        public static void mostrarFilme() {
            Console.Write("Digite o código do filme: ");
            int codigoFilme = int.Parse(Console.ReadLine());
            int posFilme = Program.filmes.FindIndex(x => x.codigo == codigoFilme);
            if (posFilme == -1) {
                throw new ModelException("Filme não consta no cadastro: " + codigoFilme);
            }
            Console.WriteLine(Program.filmes[posFilme]);
            Console.WriteLine("Participações:");
        }
    }
}
