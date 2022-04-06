using System;
using System.Collections.Generic;
using System.Text;
using TP3Alunos.Domain.ValueObject;

namespace TP3Alunos.Domain.Entity
{
    public class Aluno
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Matricula Matricula { get; set; }

        public Aluno() { }
        
        public Aluno(string nome, Matricula matricula) {
            this.Nome = nome;
            this.Matricula = Matricula;
        }

    }
}
