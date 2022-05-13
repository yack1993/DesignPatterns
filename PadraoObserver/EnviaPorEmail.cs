using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public class EnviaPorEmail : IAcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Email");
        }
    }
}
