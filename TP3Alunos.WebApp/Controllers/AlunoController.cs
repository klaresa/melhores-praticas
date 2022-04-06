using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP3Alunos.Domain.Entity;
using TP3Alunos.Domain.Interfaces;

namespace TP3Alunos.WebApp.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {

            return View();
        }

        // GET: aluno/lista
        public ActionResult Lista()
        {
            var alunos = _service.ListarTodos();
            return View(alunos);
        }

        // POST: aluno/Salvar
        [HttpPost]
        public ActionResult Salvar(string nome, string matricula)
        {
            if (nome == null && matricula == null)
            {
                return RedirectToAction("Lista"); ;
            }

            var request = new AlunoDto
            {
                Nome = nome,
                Matricula = matricula
            };

            _service.Salvar(request);
            return RedirectToAction("Lista");
        }

        // POST: aluno/remover/5
        [HttpGet]
        public ActionResult Remover(string id)
        {
            try
            {
                _service.Remover(Guid.Parse(id));
                return RedirectToAction("Lista");
            }
            catch
            {
                return View();
            }
        }
    }
}
