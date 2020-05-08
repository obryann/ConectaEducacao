using Api.Domain;
using System;
using System.Collections.Generic;

namespace Api.Application.Repository
{
    public interface IAlunoReadOnlyRepository
    {
        void Add(Aluno aluno);
        void Remove(Guid guid);
        void Update(Aluno aluno);
        Aluno GetById(Guid id);
        List<Aluno> GetAll();
    }
}
