using Api.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.UseCase.Disciplina
{
    public class DisciplinaAdicionarUseCase : IDisciplinaAdicionarUseCase
    {
        private readonly IDisciplinaReadOnlyRepository disciplinaReadOnlyRepository;
        public DisciplinaAdicionarUseCase(IDisciplinaReadOnlyRepository disciplinaReadOnlyRepository)
        {
            this.disciplinaReadOnlyRepository = disciplinaReadOnlyRepository;
        }
        public Guid Execute(Domain.Disciplina disciplina)
        {
            disciplinaReadOnlyRepository.Add(disciplina);
            return disciplina.IdDisciplina;
        }
    }
}
