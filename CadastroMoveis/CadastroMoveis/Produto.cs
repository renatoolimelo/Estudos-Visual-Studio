using System;
using System.Globalization;

namespace CadastroMoveis {
    class Produto : IComparable {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco) {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString() {
            return codigo
                + ", "
                + descricao
                + ", "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Produto compara = (Produto)obj;
            int resultado = descricao.CompareTo(compara.descricao);
            if(resultado != 0) {
                return resultado;
            }
            else {
                return -preco.CompareTo(compara.preco);
            }
        }
    }
}
