using System;

namespace PadraoStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(orcamento, iss);
            calculador.RealizarCalculo(orcamento, icms);

            Console.ReadKey();
        }
    }
}
