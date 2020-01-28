using System;

namespace Desafio_Mattos
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory factory = null;
            Console.Write("Digite qual é o tipo de cartão de seu interesse: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "gold":
                    factory = new GoldFactory(50000, 0);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(100000, 500);
                    break;
                case "black":
                    factory = new BlackFactory(500000, 1000);
                    break;
            }

            CartaoDeCredito cartaoDeCredito = factory.GetCartaoDeCredito();
            Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");
            Console.WriteLine("Tipo do Cartão: {0}\nLimite: R$ {1}\nAnualidade: R$ {2}",
                cartaoDeCredito.TipoCartao, cartaoDeCredito.Limite, cartaoDeCredito.Anualidade);
            Console.ReadKey();
        }
    }
}
