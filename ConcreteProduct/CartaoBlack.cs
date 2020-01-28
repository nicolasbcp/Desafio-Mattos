using System;

namespace Desafio_Mattos {
    class CartaoBlack : CartaoDeCredito {
        private readonly string _tipoCartao;
        private int _limite;
        private int _anualidade;

        public CartaoBlack (int limite, int anualidade) { 
            _tipoCartao = "Black";
            _limite = limite;
            _anualidade = anualidade;
        }

        public override string TipoCartao {
            get { return _tipoCartao; }
        }

        public override int Limite {
            get { return _limite; }
            set { _limite = value; }
        }

        public override int Anualidade {
            get { return _anualidade; }
            set { _anualidade = value; }
        }
    }
}