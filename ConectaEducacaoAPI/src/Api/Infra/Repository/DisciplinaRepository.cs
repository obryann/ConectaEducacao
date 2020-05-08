using Api.Application.Repository;
using Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Infra.Repository
{
    public class DisciplinaRepository : IDisciplinaReadOnlyRepository
    {
        public void Add(Disciplina disciplina)
        {
            using (var context = new Context())
            {
                context.Add(disciplina);

                context.SaveChanges();
            }
        }

        public List<Disciplina> GetAll()
        {
            using (var context = new Context())
            {
                return context.Disciplina.ToList();
            }
        }

        public Disciplina GetById(Guid id)
        {
            using (var context = new Context())
            {
                return context.Disciplina.Find(id);
            }
        }

        public void Remove(Guid guid)
        {
            using (var context = new Context())
            {
                var disciplina = GetById(guid);

                context.Remove(disciplina);
                context.SaveChanges();
            }
        }

        public void Update(Disciplina disciplina)
        {
            using (var context = new Context())
            {
                context.Update(disciplina);
                context.SaveChanges();
            }
        }
    }
}
