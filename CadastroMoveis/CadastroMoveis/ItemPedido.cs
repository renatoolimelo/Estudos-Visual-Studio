using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
