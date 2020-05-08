using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain
{
    public class Disciplina
    {
        public Guid IdDisciplina { set; get; }
        public string NomeDisciplina { set; get; } 
        public string CargaHoraria { set; get; } 
    }
}
