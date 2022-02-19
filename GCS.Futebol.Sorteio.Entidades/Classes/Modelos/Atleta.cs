using GCS.Futebol.Sorteio.Entidades.Classes.DTO;
using GCS.Futebol.Sorteio.Entidades.Enums;
using GCS.Futebol.Sorteio.Entidades.Interfaces;

namespace GCS.Futebol.Sorteio.Entidades.Classes.Modelos;

public class Atleta : EntityBase, IAggregateRoot
{
    #region Variáveis
    private readonly List<EnumPosicaoAtleta> _posicoes = new();
    #endregion

    #region Propriedades
    public string Nome { get; private set; }
    public string? Apelido { get; private set; }
    public EnumNotaAtleta Nota { get; private set; }
    public string Posicoes { get; private set; }
    public IReadOnlyCollection<EnumPosicaoAtleta> PosicoesFormatadas => _posicoes;

    //Passar para a ViewModel
    public string NomeMostrar => Apelido ?? Nome;
    #endregion

    #region Construtores
    /// <summary>
    /// Somente para o EF
    /// </summary>
    protected Atleta() { }

    public Atleta(DTOCadastrarAtleta cadastrarAtleta)
        : base()
        => PreencherDados(cadastrarAtleta.Nome, cadastrarAtleta.Apelido, cadastrarAtleta.Nota);
    #endregion

    #region Métodos
    public void AdicionarPosicao(EnumPosicaoAtleta posicaoAtleta)
    {
        if (!_posicoes.Any(x => x == posicaoAtleta))
            _posicoes.Add(posicaoAtleta);
    }

    public void RemoverPosicao(EnumPosicaoAtleta posicaoAtleta)
        => _posicoes.Remove(posicaoAtleta);

    public void AlterarNota(EnumNotaAtleta notaAtleta) => Nota = notaAtleta;

    public DTORetornoCadastrarAtleta ParaDTORetornoCadastrarAtleta()
        => new(Id, Nome, Apelido, Nota, PosicoesFormatadas.ToList());

    private void PreencherDados(string nome, string? apelido, EnumNotaAtleta nota)
    {
        Nome = nome;
        Apelido = apelido;
        Nota = nota;
    }
    #endregion
}
