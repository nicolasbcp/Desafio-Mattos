namespace Desafio_Mattos { 
    class GoldFactory : CartaoFactory {
        private int _limite;
        private int _anualidade;

        public GoldFactory(int limite, int anualidade) { 
            _limite = limite;
            _anualidade = anualidade;
        }

        public override CartaoDeCredito GetCartaoDeCredito() {
            return new CartaoGold(_limite, _anualidade);
        }
    }
}