using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempo.Models
{
    public class DTOEstadoCidadePrevisao
    {
        public List<Estado> Estados = new List<Estado>();
        public List<Cidade> Cidades = new List<Cidade>();
        public List<PrevisaoClima> Previsoes = new List<PrevisaoClima>();

        public int CidadeSelecionada { get; set; }
    }
}