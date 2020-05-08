using Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infra.Entities.Map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno", "public");
            builder.HasKey(p => p.IdAluno);
            builder.Property(p => p.CPF)
                .IsRequired()
                .HasColumnType("varchar(14)")
                .HasColumnName("CPF");
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)")
                .HasColumnName("Nome");
            builder.Property(p => p.Matricula)
                .IsRequired()
                .HasColumnType("varchar(10)")
                .HasColumnName("Matricula");
            builder.Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("DataNascimento");
        }
    }
}