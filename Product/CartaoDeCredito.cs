namespace Desafio_Mattos {
    abstract class CartaoDeCredito {
        public abstract string TipoCartao {get;}
        public abstract int Limite {get; set;}
        public abstract int Anualidade {get; set;}

    }
}