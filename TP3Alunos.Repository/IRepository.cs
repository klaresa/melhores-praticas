using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TP3Alunos.Repository
{
    public interface IRepository<T>
    {
        T Salvar(T objeto);
        T Editar(T obj);
        void Remover(Guid id);
        T Listar(Guid id);
        List<T> ListarTodos();


        List<T> ListarPor(Expression<Func<T, bool>> expression);
    }
}
