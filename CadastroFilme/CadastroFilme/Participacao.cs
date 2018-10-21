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
    }
}
