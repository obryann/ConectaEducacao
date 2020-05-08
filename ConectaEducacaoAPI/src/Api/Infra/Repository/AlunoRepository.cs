using Api.Application.Repository;
using Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Infra.Repository
{
    public class AlunoRepository : IAlunoReadOnlyRepository
    {
        public void Add(Aluno aluno)
        {
            using (var context = new Context())
            {
                context.Aluno.Add(aluno);
                context.SaveChanges();
            }
        }

        public List<Aluno> GetAll()
        {
            using (var context = new Context())
            {
                return context.Aluno.ToList();
            }
        }

        public Aluno GetById(Guid id)
        {
            using (var context = new Context())
            {
                return context.Aluno.Find(id);
            }
        }

        public void Remove(Guid guid)
        {
            using (var context = new Context())
            {
                var aluno = GetById(guid);

                context.Remove(aluno);
                context.SaveChanges();
            }
        }

        public void Update(Aluno aluno)
        {
            using (var context = new Context())
            {
                context.Update(aluno);
                context.SaveChanges();
            }
        }
    }
}
