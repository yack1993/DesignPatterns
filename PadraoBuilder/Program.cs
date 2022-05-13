using System;

namespace PadraoBuilder
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

            NotaFiscal nf = nota.Constroi();


            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Imposto);
            Console.ReadKey();
        }
    }
}
