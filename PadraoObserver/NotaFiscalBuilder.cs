using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public IList<IAcaoAposGerarNotaFiscal> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNotaFiscal>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach(IAcaoAposGerarNotaFiscal acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            //new EnviaPorEmail().Executa(nf);
            //new NotaFiscalDao().Executa(nf);
            //new EnviaPorSms().Executa(nf);

            return nf;
        }


        public void AdicionaAcao(IAcaoAposGerarNotaFiscal novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;
        }
    }
}
