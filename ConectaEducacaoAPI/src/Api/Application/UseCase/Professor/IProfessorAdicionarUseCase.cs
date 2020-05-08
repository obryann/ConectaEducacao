using System;

namespace Api.Application.UseCase.Professor
{
    public interface IProfessorAdicionarUseCase
    {
        Guid Execute(Domain.Professor professor);
    }
}
