using System;

namespace Desafio_Mattos {
    class CartaoGold : CartaoDeCredito {
        private readonly string _tipoCartao;
        private int _limite;
        private int _anualidade;

        public CartaoGold (int limite, int anualidade) {
            _tipoCartao = "Gold";
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