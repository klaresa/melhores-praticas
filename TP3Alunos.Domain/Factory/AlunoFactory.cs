using System;
using System.Collections.Generic;
using System.Text;
using TP3Alunos.Domain.Entity;
using TP3Alunos.Domain.ValueObject;

namespace TP3Alunos.Domain.Factory
{
    public static class AlunoFactory
    {
        public static Entity.Aluno Criar(string nome, string matricula)
        {

            Aluno novo = new Aluno
            {
                Id = Guid.NewGuid(),  
                Nome = nome,
                Matricula = new Domain.ValueObject.Matricula(matricula)
            };
            //Aluno aluno = new Aluno(nome, new Matricula(matricula));
            //aluno.Id = Guid.NewGuid();
            return novo;
        }
    }
}
