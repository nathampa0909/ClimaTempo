using ClimaTempo.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ClimaTempo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var climaTempoContext = new ClimaTempoContext();
            var dtoEstadoCidadePrevisao = new DTOEstadoCidadePrevisao() {
                Cidades = climaTempoContext.Cidade.OrderBy(c => c.Nome).ToList(),
                Estados = climaTempoContext.Estado.OrderBy(e => e.UF).ToList(),
                Previsoes = climaTempoContext.PrevisaoClima.ToList()
            };

            return View(dtoEstadoCidadePrevisao);
        }

        public ActionResult Sobre => View();

        public ActionResult ObtenhaClimas(int cidadeId)
        {
            var climaTempoContext = new ClimaTempoContext();
            var dtoEstadoCidadePrevisao = new DTOEstadoCidadePrevisao()
            {
                Cidades = climaTempoContext.Cidade.OrderBy(c => c.Nome).ToList(),
                Estados = climaTempoContext.Estado.OrderBy(e => e.UF).ToList(),
                Previsoes = climaTempoContext.PrevisaoClima.ToList().FindAll(p => p.CidadeId == cidadeId)
            };

            ViewBag.NomeCidade = dtoEstadoCidadePrevisao.Cidades.Find(c => c.Id == cidadeId).Nome;

            return PartialView("_ClimaCidadePartialView", dtoEstadoCidadePrevisao);
        }
    }
}