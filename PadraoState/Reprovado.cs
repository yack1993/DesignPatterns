using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoState
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extras");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já aprovado");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento não pode ser reprovado");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
