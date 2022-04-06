using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TP3Alunos.Domain.Entity;

namespace TP3Alunos.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> _alunos = new List<Aluno>();

        public Aluno Editar(Aluno aluno)
        {
            try
            {
                var alunos = AlunoRepository._alunos
                    .FirstOrDefault(al => al.Id == aluno.Id);
                AlunoRepository._alunos.Remove(aluno);
                AlunoRepository._alunos.Add(aluno);
                
                return alunos;
            }
            catch
            {
                throw new Exception("Erro ao editar.");
            }
        }

        public Aluno Listar(Guid id)
        {
            try
            {
                return AlunoRepository._alunos.FirstOrDefault(al => al.Id == id);
            }
            catch
            {
                throw new Exception("Erro encontrar aluno.");
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                var aluno = AlunoRepository._alunos.FirstOrDefault(Func => Func.Id == id);
                AlunoRepository._alunos.Remove(aluno);
            }
            catch
            {
                throw new Exception("Erro remover aluno.");
            }
        }

        public Aluno Salvar(Aluno aluno)
        {
            try
            {
                _alunos.Add(aluno);
                return aluno;
            }
            catch
            {
                throw new Exception("Erro adicionar aluno.");
            }
        }

        public List<Aluno> ListarPor(Expression<Func<Aluno, bool>> expression)
        {
            return AlunoRepository._alunos.Where(expression.Compile()).ToList();
        }

        public List<Aluno> ListarTodos()
        {
           return _alunos;
        }
    }
}
