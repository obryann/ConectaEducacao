using Api.Application.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.UseCase.Disciplina
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaAdicionarUseCase disciplinaAdicionarUseCase;

        public DisciplinaController(IDisciplinaAdicionarUseCase disciplinaAdicionarUseCase)
        {
            this.disciplinaAdicionarUseCase = disciplinaAdicionarUseCase;
        }
        [HttpPost]
        public IActionResult Adicionar(Domain.Disciplina disciplina)
        {
            var IdDisciplina = disciplinaAdicionarUseCase.Execute(disciplina);
            return Ok(IdDisciplina);
        }
    }
}