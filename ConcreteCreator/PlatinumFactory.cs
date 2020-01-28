namespace Desafio_Mattos { 
    class PlatinumFactory : CartaoFactory {
        private int _limite;
        private int _anualidade;

        public PlatinumFactory(int limite, int anualidade) { 
            _limite = limite;
            _anualidade = anualidade;
        }

        public override CartaoDeCredito GetCartaoDeCredito() {
            return new CartaoPlatinum(_limite, _anualidade);
        }
    }
}