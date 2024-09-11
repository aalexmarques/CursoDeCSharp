using System;
using System.Globalization;
namespace Course {
    class Produto {
        private string _nome;
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
           _nome = nome;
           _preco = preco;
           _quantidade = quantidade;
        }


        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1) { _nome = value; } }   
        }

        public double Preco {
            get { return _preco; }
        }

        public double Quantidade {
            get { return _quantidade; }
        }


        public double ValorTotalEmStock() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}