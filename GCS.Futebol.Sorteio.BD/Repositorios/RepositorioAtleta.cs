using GCS.Futebol.Sorteio.BD.Contextos;
using GCS.Futebol.Sorteio.Entidades.Classes.Modelos;
using GCS.Futebol.Sorteio.Entidades.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GCS.Futebol.Sorteio.BD.Repositorios
{
    public class RepositorioAtleta : IRepositorioAtleta
    {
        private readonly ContextoAtleta _contextoAtleta;

        public IUnityOfWork UnityOfWork => _contextoAtleta;

        public RepositorioAtleta(ContextoAtleta contextoAtleta)
        {
            _contextoAtleta = contextoAtleta;
        }

        public void Alterar(Atleta atleta)
            => _contextoAtleta.Atletas.Update(atleta);

        public async Task CriarAsync(Atleta atleta)
            => await _contextoAtleta.Atletas.AddAsync(atleta);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<Atleta> ObterAsync(Guid id)
            => await _contextoAtleta.Atletas.FindAsync(id);

        public async Task<IEnumerable<Atleta>> ObterTodosAsync()
            => await _contextoAtleta.Atletas.AsNoTracking().ToListAsync();
    }
}
