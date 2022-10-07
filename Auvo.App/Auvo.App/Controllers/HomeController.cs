using Auvo.App.Services;
using Auvo.App.ViewModels;
using Newtonsoft.Json;
using System;
using System.Web.Mvc;

namespace Auvo.App.Controllers
{
    public class HomeController : Controller
    {
        CidadeService serviceCidade;
        PrevisaoClimaService previsaoClimaService;

        public HomeController()
        {
            serviceCidade = new CidadeService();
            previsaoClimaService = new PrevisaoClimaService();
        }

        public ActionResult Index()
        {
            ClimaTempoViewModel model = new ClimaTempoViewModel();
            model.Cidades = serviceCidade.Listar();
            model.MaisFrias = previsaoClimaService.ListarCidadesMaisFriasDia(DateTime.Now, 3);
            model.MaisQuentes = previsaoClimaService.ListarCidadesMaisQuentesDia(DateTime.Now, 3);

            return View("Index", model);
        }       

        public string PrevisaoCidade(int cidadeId)
        {
            return JsonConvert.SerializeObject(previsaoClimaService.ListarPorCidadeId(cidadeId, DateTime.Now.Date, 7));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}