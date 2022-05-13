using System;

namespace PadraoChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDesconto calculador = new CalculadorDeDesconto();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogão", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("Xbox", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
