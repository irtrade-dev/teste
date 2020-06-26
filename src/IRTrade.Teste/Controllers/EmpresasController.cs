using IRTrade.Teste.Models.Empresas;
using System.Collections.Generic;
using System.Web.Http;

namespace IRTrade.Teste.Controllers
{
    public class EmpresasController : ApiController
    {
        private static List<Empresa> empresas = new List<Empresa>();

        [HttpGet]
        public List<Empresa> ChamarListaEmpresa()
        {
            return empresas;
        }
    }
}
