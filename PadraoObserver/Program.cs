using System;

namespace PadraoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder nota = new NotaFiscalBuilder();
            nota.ParaEmpresa("Bima")
            .ComCnpj("234.456.2345/001-12")
            .ComItem(new ItemDaNota("item 1", 100.00))
            .ComItem(new ItemDaNota("item 2", 200.00))
            .NaDataAtual()
            .ComObservacoes("Big empresa");


            nota.AdicionaAcao(new EnviaPorEmail());
            nota.AdicionaAcao(new EnviaPorSms());
            nota.AdicionaAcao(new NotaFiscalDao());

            NotaFiscal nf = nota.Constroi();


            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Imposto);
            Console.ReadKey();
        }
    }
}
