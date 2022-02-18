using GCS.Futebol.Sorteio.Entidades.Enums;

namespace GCS.Futebol.Sorteio.Entidades.Classes.DTO;

public class DTOCadastrarAtleta
{
    public DTOCadastrarAtleta(string nome, string? apelido, EnumNotaAtleta nota)
    {
        Nome = nome;
        Apelido = apelido;
        Nota = nota;
    }

    public string Nome { get; set; }
    public string? Apelido { get; set; }
    public EnumNotaAtleta Nota { get; set; }
    public List<EnumPosicaoAtleta> Posicoes { get; set; } = new List<EnumPosicaoAtleta>();
}
