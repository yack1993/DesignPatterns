using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoTemplateMethod
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public override bool DeseUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

    }
}
