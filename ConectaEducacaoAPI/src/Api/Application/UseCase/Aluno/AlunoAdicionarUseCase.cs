using Api.Application.Repository;
using System;

namespace Api.Application.UseCase.Aluno
{
    public class AlunoAdicionarUseCase : IAlunoAdicionarUSeCase
    {
        private readonly IAlunoReadOnlyRepository alunoReadOnlyRepository;
        public AlunoAdicionarUseCase(IAlunoReadOnlyRepository alunoReadOnlyRepository)
        {
            this.alunoReadOnlyRepository = alunoReadOnlyRepository;
        }

        public Guid Execute(Domain.Aluno aluno)
        {
            alunoReadOnlyRepository.Add(aluno);
            return aluno.IdAluno;
        }
    }
}