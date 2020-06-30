using IRTrade.Teste.Data;
using IRTrade.Teste.Interfaces.Empresas;
using IRTrade.Teste.Models.Empresas;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Repositories.Empresas
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresaRepository
    {
        private TestDbContext _context;
        public EmpresaRepository(TestDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Empresa> ObterPorUf(string uf)
        {
            throw new NotImplementedException();
        }
    }
}