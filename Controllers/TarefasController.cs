using Microsoft.AspNetCore.Mvc;
using ApiTarefas.Models;

namespace ApiTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private static List<Tarefa> tarefas = new List<Tarefa>()
        {
            new Tarefa { Id = 1, Nome = "Estudar .NET", Concluida = false }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tarefas);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tarefa tarefa)
        {
            tarefas.Add(tarefa);
            return Ok(tarefa);
        }
    }
}
