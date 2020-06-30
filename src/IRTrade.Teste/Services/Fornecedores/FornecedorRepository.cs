using IRTrade.Teste.Interfaces.Fornecedores;
using IRTrade.Teste.Models.Fornecedores;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Services.Fornecedores
{
    public class FornecedorRepository : GenericRepository<Fornecedor>, IFornecedorRepository
    {
        public Fornecedor ObterPorCpfCnpj(string cpfCnpj)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ObterPorDataCadastro(DateTime dataCadastro)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}