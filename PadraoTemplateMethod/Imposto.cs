﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoTemplateMethod
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
