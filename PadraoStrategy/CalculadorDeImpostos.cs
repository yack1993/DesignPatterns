using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public class CalculadorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);

        }
    }
}
