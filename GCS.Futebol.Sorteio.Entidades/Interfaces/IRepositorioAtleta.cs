using GCS.Futebol.Sorteio.Entidades.Classes.Modelos;

namespace GCS.Futebol.Sorteio.Entidades.Interfaces;

public interface IRepositorioAtleta
{
    Atleta Criar(Atleta atleta);
    Atleta Alterar(Atleta atleta);
}
