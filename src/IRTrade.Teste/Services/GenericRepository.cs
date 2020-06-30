using IRTrade.Teste.Interfaces;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Deletar(long id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T obj)
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(long id)
        {
            throw new NotImplementedException();
        }

        public List<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar()
        {
            throw new NotImplementedException();
        }
    }
}