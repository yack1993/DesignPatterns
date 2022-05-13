using System;

namespace PadraoState
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);

            Console.WriteLine("Valor Inicial:" + reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();

            //reforma.AplicaDescontoExtra(); //exception

            Console.ReadKey();
        }
    }
}
