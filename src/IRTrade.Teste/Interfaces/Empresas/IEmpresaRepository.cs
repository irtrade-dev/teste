using IRTrade.Teste.Models.Empresas;
using System.Collections.Generic;

namespace IRTrade.Teste.Interfaces.Empresas
{
    public interface IEmpresaRepository : IGenericRepository<Empresa>
    {
        List<Empresa> ObterPorUf(string uf);
    }
}
