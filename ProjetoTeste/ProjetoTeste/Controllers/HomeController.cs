using ProjetoTeste.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoTeste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Publico obj = new Publico()
            {
                QtdFeminino = 30,
                QtdMasculino = 50,
                QtdNaoInformado = 10,
                QtdTotal = 30 + 50 + 10
            };

            return View(obj);
        }
    }
}