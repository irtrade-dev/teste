using IRTrade.Teste.Models.Empresas;
using System.Collections.Generic;
using System.Web.Http;

namespace IRTrade.Teste.Controllers
{
    public class EmpresasController : ApiController
    {

        [HttpGet]
        public List<Empresa> ChamarListaEmpresa()
        {
            var empresas = new List<Empresa>();
            return empresas;
        }
    } 
}
