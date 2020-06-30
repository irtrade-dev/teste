using IRTrade.Teste.Interfaces.Empresas;
using IRTrade.Teste.Models.Empresas;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Services.Empresas
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresaRepository
    {
        public List<Empresa> ObterPorUf(string uf)
        {
            throw new NotImplementedException();
        }
    }
}