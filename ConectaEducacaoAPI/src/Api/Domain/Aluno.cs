using System;
using System.Net.Mail;

namespace Api.Domain
{
    public class Aluno
    {
        public Guid IdAluno { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
