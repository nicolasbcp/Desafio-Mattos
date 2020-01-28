using System;

namespace Desafio_Mattos {
    class CartaoPlatinum : CartaoDeCredito {
        private readonly string _tipoCartao;
        private int _limite;
        private int _anualidade;

        public CartaoPlatinum (int limite, int anualidade) {
            _tipoCartao = "Platinum";
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