using IRTrade.Teste.Models.Fornecedores;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Interfaces.Fornecedores
{
    public interface IFornecedorRepository : IGenericRepository<Fornecedor>
    {
        List<Fornecedor> ObterPorNome(string nome);
        Fornecedor ObterPorCpfCnpj(string cpfCnpj);
        List<Fornecedor> ObterPorDataCadastro(DateTime dataCadastro);
    }
}
