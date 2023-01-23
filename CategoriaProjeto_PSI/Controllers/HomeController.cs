using Servico.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CategoriaProjeto_PSI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private ProdutoServico produtoServico = new ProdutoServico();
        public ActionResult Index()
        {
            return View(produtoServico.ObterProdutosClassificadosPorNome());
        }
    }
}