using System;
using System.Globalization;

namespace Aula42 {

    // teste para upload github 
    internal class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        

        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

       public string Nome {
            get {
                return _nome; 
            }
            set {
                if (value != null && Nome.Length > 1)
                    _nome = value;
            }
        }
       
           

        public double ValorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarEstoque(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverEstoque(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }




        public override string ToString() {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
