using System.Globalization;

namespace CadastroMoveis {
    class ItemPedido {
        public int codigoProduto { get; set; }
        public int codigoPedido { get; set; }
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }

        public ItemPedido(int codigoProduto, int codigoPedido, int quantidade, double porcentagemDesconto) {
            this.codigoProduto = codigoProduto;
            this.codigoPedido = codigoPedido;
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
        }

        public override string ToString() {
            string tela = "";
            double subtotal, total = 0;
            for (int i = 0; i < Program.itensPedido.Count; i++) {
                if (Program.itensPedido[i].codigoPedido == codigoPedido) {
                    int codigoProduto = Program.itensPedido[i].codigoProduto;
                    int pos = Program.produtos.FindIndex(x => x.codigo == codigoProduto);
                    subtotal = Program.produtos[pos].preco * Program.itensPedido[i].quantidade * (1 - Program.itensPedido[i].porcentagemDesconto / 100);
                    total += subtotal;
                    tela = tela + Program.produtos[pos].descricao
                        + ", Preço: "
                        + Program.produtos[pos].preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", Qte: "
                        + Program.itensPedido[i].quantidade
                        + ", Desconto: "
                        + Program.itensPedido[i].porcentagemDesconto.ToString("F1", CultureInfo.InvariantCulture)
                        + "%, Subtotal: "
                        + subtotal.ToString("F2", CultureInfo.InvariantCulture)
                        + "\n";
                }
            }
            return tela
                + "Total do pedido: "
                + total;
        }
    }
}
