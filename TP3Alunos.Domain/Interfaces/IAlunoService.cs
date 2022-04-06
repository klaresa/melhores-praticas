using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TP3Alunos.Domain.Entity;

namespace TP3Alunos.Domain.Interfaces
{
    public interface IAlunoService
    {
        Aluno Salvar(AlunoDto dto);
        Aluno Editar(Guid id, AlunoDto dto);
        void Remover(Guid id);
        Aluno Listar(Guid id);
        IEnumerable<Aluno> ListarTodos();

        //List<Aluno> ListarPor(Expression<Func<T, bool>> expression);
    }
}
