﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class ItemDaNota
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(String nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
