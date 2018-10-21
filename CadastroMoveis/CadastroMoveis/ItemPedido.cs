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
            return ", Qte: "
                + quantidade
                + ", Desconto: "
                + porcentagemDesconto.ToString("F1", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double subTotal() {
            double precoProduto = 0;
            for(int i = 0; i < Program.produtos.Count; i++) {
                if (codigoProduto == Program.produtos[i].codigo) {
                    precoProduto = Program.produtos[i].preco;
                }
            }
            return quantidade * precoProduto * (1 - porcentagemDesconto / 100);
        }
    }
}
