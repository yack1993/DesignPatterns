using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Imposto { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public String Observacoes { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao, double valorBruto, 
            double imposto, IList<ItemDaNota> itens, String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Imposto = imposto;
            Itens = itens;
            Observacoes = observacoes;

        }
    }
}
