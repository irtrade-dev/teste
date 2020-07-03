using IRTrade.Teste.Data;
using IRTrade.Teste.Interfaces.Telefones;
using IRTrade.Teste.Models.Telefones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRTrade.Teste.Repositories.Telefones
{
    public class TelefoneRepository : GenericRepository<Telefone>, ITelefoneRepository
    {
        private TestDbContext _context;

        public TelefoneRepository(TestDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Telefone> ObterNumeros(string ddd, string numero)
        {
            throw new NotImplementedException();
        }
    }
}