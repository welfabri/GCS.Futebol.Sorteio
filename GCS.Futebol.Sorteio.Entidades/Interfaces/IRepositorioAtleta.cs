using GCS.Futebol.Sorteio.Entidades.Classes.Modelos;

namespace GCS.Futebol.Sorteio.Entidades.Interfaces;

public interface IRepositorioAtleta : IRepositorio<Atleta>
{ 
    Task<Atleta> ObterAsync(Guid id);
    Task<IEnumerable<Atleta>> ObterTodosAsync();

    Task CriarAsync(Atleta atleta);
    void Alterar(Atleta atleta);
}
