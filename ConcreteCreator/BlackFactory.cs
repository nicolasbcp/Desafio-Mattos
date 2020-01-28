namespace Desafio_Mattos { 
    class BlackFactory : CartaoFactory {
        private int _limite;
        private int _anualidade;

        public BlackFactory(int limite, int anualidade) { 
            _limite = limite;
            _anualidade = anualidade;
        }

        public override CartaoDeCredito GetCartaoDeCredito() {
            return new CartaoBlack(_limite, _anualidade);
        }
    }
}