using GCS.Futebol.Sorteio.BD.Mapeamentos;
using GCS.Futebol.Sorteio.Entidades.Classes.Modelos;
using GCS.Futebol.Sorteio.Entidades.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GCS.Futebol.Sorteio.BD.Contextos;

public class ContextoAtleta : DbContext, IUnityOfWork
{
    public ContextoAtleta(DbContextOptions<ContextoAtleta> options) 
        : base(options) { }

    public DbSet<Atleta> Atletas { get; set; }

    public async Task<bool> CommitAsync()
        => await base.SaveChangesAsync() > 0;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MapeamentoAtleta).Assembly);
    }
}
