using System;

namespace Api.Application.UseCase.Disciplina
{
    public interface IDisciplinaAdicionarUseCase
    {
        Guid Execute(Domain.Disciplina disciplina);
    }
}