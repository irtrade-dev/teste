using IRTrade.Teste.Models.Fornecedores;
using System.Collections.Generic;
using System.Web.Http;

namespace IRTrade.Teste.Controllers
{
    public class FornecedoresController : ApiController
    {

        [HttpGet]
        public List<Fornecedor> ChamarListaFornecedor()
        {
            var fornecedores = new List<Fornecedor>();
            return fornecedores;
        }
    }
}
