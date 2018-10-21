namespace CadastroFilme {
    class Filme {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }

        public Filme(int codigo, string titulo, int ano) {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
        }

        public override string ToString() {
            return "Filme "
                + codigo
                + ", Título: "
                + titulo
                + ", Ano: "
                + ano;
        }
    }
}
