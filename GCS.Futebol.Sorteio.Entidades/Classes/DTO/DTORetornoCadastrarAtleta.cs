using GCS.Futebol.Sorteio.Entidades.Enums;

namespace GCS.Futebol.Sorteio.Entidades.Classes.DTO
{
    public class DTORetornoCadastrarAtleta
    {
        public DTORetornoCadastrarAtleta(Guid id, string nome, string? apelido, EnumNotaAtleta nota, 
            List<EnumPosicaoAtleta> posicoes)
        {
            Nome = nome;
            Apelido = apelido;
            Nota = nota;
            Id = id;
            Posicoes = posicoes;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string? Apelido { get; set; }
        public EnumNotaAtleta Nota { get; set; }
        public List<EnumPosicaoAtleta> Posicoes { get; set; }
    }
}
