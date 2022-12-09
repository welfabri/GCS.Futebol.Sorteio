using GCS.Futebol.Sorteio.API.V1.Modelos.Enums;

namespace GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO;

public class DTORetornoCadastrarJogador
{
    public DTORetornoCadastrarJogador(int id, string nome, string? apelido, EnumNotaAtleta nota,
        List<EnumPosicaoAtleta> posicoes)
    {
        Nome = nome;
        Apelido = apelido;
        Nota = nota;
        Id = id;
        _posicoes = posicoes;
    }

    List<EnumPosicaoAtleta> _posicoes = new();

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string? Apelido { get; private set; }
    public EnumNotaAtleta Nota { get; private set; }
    public IReadOnlyList<EnumPosicaoAtleta> Posicoes => _posicoes;
}
