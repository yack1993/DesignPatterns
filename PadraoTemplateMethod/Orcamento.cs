using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoTemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Items { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Items = new List<Item>();
        }

        public void AdiconaItem(Item item)
        {
            Items.Add(item);
        }
    }
}
