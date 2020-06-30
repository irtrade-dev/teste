using IRTrade.Teste.Data;
using IRTrade.Teste.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private TestDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(TestDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

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