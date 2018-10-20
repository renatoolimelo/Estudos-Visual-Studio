using System;

namespace CadastroMoveis {
    class Pedido {

        public int codigo { get; set; }
        public DateTime data { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano) {
            this.codigo = codigo;
            this.data = new DateTime(ano, mes, dia);
        }
    }
}
