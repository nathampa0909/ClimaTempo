﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempo.Models
{
    public class ResponseClima
    {
        public int temp { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    }
}