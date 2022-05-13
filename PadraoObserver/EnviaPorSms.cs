using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public class EnviaPorSms : IAcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("sms");
        }
    }
}
