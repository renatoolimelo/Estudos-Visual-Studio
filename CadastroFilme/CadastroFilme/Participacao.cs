using System.Globalization;

namespace CadastroFilme {
    class Participacao {
        public double desconto { get; set; }
        public int codigoFilme { get; set; }
        public int codigoArtista { get; set; }

        public Participacao(double desconto, int codigoFilme, int codigoArtista) {
            this.desconto = desconto;
            this.codigoFilme = codigoFilme;
            this.codigoArtista = codigoArtista;
        }

        public override string ToString() {
            return desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + custo().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double custo() {
            int pos = Program.artistas.FindIndex(x => x.codigo == codigoArtista);
            return Program.artistas[pos].cache - desconto;
        }

    }
}
