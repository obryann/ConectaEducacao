using Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Entities.Map
{
    public class DisiplinaMap : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.ToTable("Disciplina", "public");
            builder.HasKey(p => p.IdDisciplina);
            builder.Property(p => p.NomeDisciplina)
                .IsRequired()
                .HasColumnType("varchar(60)")
                .HasColumnName("Nome");
            builder.Property(p => p.CargaHoraria)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasColumnName("CargaHoraria");
        }
    }
}
