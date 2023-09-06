using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using provaACP.Context;
using provaACP.Entities;


namespace provaACP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaContext context;
        public TarefaController(TarefaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            this.context.Add(tarefa);
            this.context.SaveChanges();
            return Ok(tarefa);
        }

        [HttpGet("{id}")]
        public IActionResult ObterId(int id)
        {
            var tarefa = this.context.Tarefas.Find(id);

            if(this.context == null)
            {
                return NotFound();
            }

            return Ok(this.context);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterNome(string nome)
        {
            var tarefas = this.context.Tarefas.Where(x => x.Titulo.Contains(nome));
            return Ok(tarefas);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
        {
            var tarefaBanco = this.context.Tarefas.Find();

            if(tarefaBanco == null)
            {
                return NotFound();
            }

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.DataHora = tarefaBanco.DataHora;
            tarefaBanco.Concluida = tarefa.Concluida;

            this.context.Tarefas.Update(tarefaBanco);
            this.context.SaveChanges();

            return Ok(tarefaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = this.context.Tarefas.Find(id);

            if(tarefaBanco == null)
            {
                return NotFound();
            }

            this.context.Tarefas.Remove(tarefaBanco);
            this.context.SaveChanges();
            return NoContent();
        }
    }
}