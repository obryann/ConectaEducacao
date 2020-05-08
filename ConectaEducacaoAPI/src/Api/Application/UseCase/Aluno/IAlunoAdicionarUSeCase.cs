using System;

namespace Api.Application.UseCase.Aluno
{
    public interface IAlunoAdicionarUSeCase
    {
        Guid Execute(Domain.Aluno aluno);
    }
}
