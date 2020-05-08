using Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Repository
{
    public interface IProfessorReadOnlyRepository
    {
        void Add(Professor professor);
        void Remove(Guid guid);
        void Update(Professor professor);
        Professor GetById(Guid id);
        List<Professor> GetAll();
    }
}
