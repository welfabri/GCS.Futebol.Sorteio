using GCS.Futebol.Sorteio.API.V1.Modelos.Enums;

namespace GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO;

public class DTOCadastrarJogador
{
    public DTOCadastrarJogador(string nome, string? apelido,
        EnumNotaAtleta nota, EnumPosicaoAtleta posicao)
    {
        Nome = nome;
        Apelido = apelido;
        Nota = nota;

        _posicoes = new();
        InserirPosicaoSeNaoExistir(posicao);
    }

    private List<EnumPosicaoAtleta> _posicoes;

    public string Nome { get; set; }
    public string? Apelido { get; set; }
    public EnumNotaAtleta Nota { get; set; }
    public IReadOnlyList<EnumPosicaoAtleta> Posicoes => _posicoes;

    public void InserirPosicaoSeNaoExistir(EnumPosicaoAtleta posicaoAtleta)
    {
        if (!_posicoes.Contains(posicaoAtleta))
            _posicoes.Add(posicaoAtleta);
    }
}
