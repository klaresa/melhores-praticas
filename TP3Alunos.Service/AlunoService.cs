using System;
using System.Collections.Generic;
using System.Linq;
using TP3Alunos.Domain.Entity;
using TP3Alunos.Domain.Factory;
using TP3Alunos.Domain.Interfaces;
using TP3Alunos.Domain.ValueObject;
using TP3Alunos.Repository;

namespace TP3Alunos.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _repository;

        public AlunoService(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public Aluno Editar(Guid id, Domain.Interfaces.AlunoDto dto)
        {
            throw new NotImplementedException();
        }

        public Aluno Listar(Guid id)
        {
            return _repository.Listar(id);
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public void Remover(Guid id)
        {
            _repository.Remover(id);
        }

        public Aluno Salvar(Domain.Interfaces.AlunoDto dto)
        {
            //Aluno novo = new Aluno
            //{
            //    Id = Guid.NewGuid(),  
            //    Nome = dto.Nome,
            //    Matricula = new Domain.ValueObject.Matricula(dto.Matricula)
            //};

            var novo = AlunoFactory.Criar(dto.Nome, dto.Matricula);
            _repository.Salvar(novo);

            return novo;
        }
    }
}
