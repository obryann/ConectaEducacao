using Api.Application.UseCase.Aluno;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.UseCase.Aluno
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoAdicionarUSeCase alunoAdicionarUSeCase;

        public AlunoController(IAlunoAdicionarUSeCase alunoAdicionarUSeCase)
        {
            this.alunoAdicionarUSeCase = alunoAdicionarUSeCase;
        }
        [HttpPost]
        public IActionResult Adicionar(Domain.Aluno aluno)
        {
            var idAluno = alunoAdicionarUSeCase.Execute(aluno);
            return Ok(idAluno);
        }
    }
}