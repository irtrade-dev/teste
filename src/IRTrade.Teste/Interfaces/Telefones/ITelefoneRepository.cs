using IRTrade.Teste.Models.Telefones;
using System.Collections.Generic;

namespace IRTrade.Teste.Interfaces.Telefones
{
    interface ITelefoneRepository : IGenericRepository<Telefone>
    {
        List<Telefone> ObterNumeros(string ddd, string numero);
    }
}
