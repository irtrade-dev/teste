using System.Collections.Generic;

namespace IRTrade.Teste.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> ObterTodos();
        T ObterPorId(long id);
        void Inserir(T obj);
        void Atualizar(T obj);
        void Deletar(long id);
        void Salvar();
    }
}
