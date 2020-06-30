using IRTrade.Teste.Data;
using IRTrade.Teste.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Deletar(long id)
        {
            var obj = ObterPorId(id);
            if(obj != null)
            {
                _dbSet.Remove(obj);
            }
        }

        public void Inserir(T obj)
        {
            _dbSet.Add(obj);
        }

        public T ObterPorId(long id)
        {
            return _dbSet.Find(id);
        }

        public List<T> ObterTodos()
        {
            return _dbSet.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}