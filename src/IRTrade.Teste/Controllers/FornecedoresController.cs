using IRTrade.Teste.Models.Fornecedores;
using System.Collections.Generic;
using System.Web.Http;

namespace IRTrade.Teste.Controllers
{
    public class FornecedoresController : ApiController
    {
        private static List<Fornecedor> fornecedores = new List<Fornecedor>();

        [HttpGet]
        public List<Fornecedor> ChamarListaFornecedor()
        {
            return fornecedores;
        }
    }
}
