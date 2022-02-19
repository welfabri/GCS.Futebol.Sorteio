using GCS.Futebol.Sorteio.Entidades.Classes.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GCS.Futebol.Sorteio.BD.Mapeamentos;

internal class MapeamentoAtleta : IEntityTypeConfiguration<Atleta>
{
    public void Configure(EntityTypeBuilder<Atleta> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(x => x.Apelido)
            .HasColumnType("varchar(25)");

        builder.Property(x => x.Nota)
            .IsRequired()
            .HasColumnType("smallint");

        builder.Property(x => x.Posicoes)
            .IsRequired()
            .HasColumnType("varchar(20)");

        builder.ToTable("Atletas");
    }
}
