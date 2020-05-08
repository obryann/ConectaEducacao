using Api.Domain;
using System;
using System.Collections.Generic;

namespace Api.Application.Repository
{
    public interface IDisciplinaReadOnlyRepository
    {
        void Add(Disciplina disciplina);
        void Remove(Guid guid);
        void Update(Disciplina disciplina);
        Disciplina GetById(Guid id);
        List<Disciplina> GetAll();
    }
}
