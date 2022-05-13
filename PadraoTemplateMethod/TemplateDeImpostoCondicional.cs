using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoTemplateMethod
{
    //class abstrata não pode ser instanciada
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeseUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeseUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
