using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoState
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Items { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Items = new List<Item>();
            //estado inical
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdiconaItem(Item item)
        {
            Items.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
