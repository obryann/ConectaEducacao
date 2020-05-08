using Api.Application.Repository;
using System;

namespace Api.Application.UseCase.Professor
{
    public class ProfessorAdicionarUseCase : IProfessorAdicionarUseCase
    {
        private readonly IProfessorReadOnlyRepository professorReadOnlyRepository;
        public ProfessorAdicionarUseCase(IProfessorReadOnlyRepository professorReadOnlyRepository)
        {
            this.professorReadOnlyRepository = professorReadOnlyRepository;
        }
        public Guid Execute(Domain.Professor professor)
        {
            this.professorReadOnlyRepository.Add(professor);
            return professor.IdProfessor;
        }
    }
}
