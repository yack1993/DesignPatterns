﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoTemplateMethod
{
    public class  IKCV : TemplateDeImpostoCondicional
    {
        public override bool DeseUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private  bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Items)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}
