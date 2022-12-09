using GCS.Futebol.Sorteio.API.V1.Modelos.Enums;

namespace GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO.Parametros
{
    public class DTOCadastrarEquipe
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string? Informacoes { get; set; }
        public string? PaginaInternet { get; set; }
        public string? LocalJogos { get; set; }
        public EnumDiasSemana[]? DiasJogos { get; set; }
        public string? HorarioJogos { get; set; }
        public string? CriterioAtletas { get; set; }
        public string? Logo { get; set; }
        public string? Mascote { get; set; }
        public string[]? Uniformes { get; set; }

        public string? FaixaEtaria { get; set; }
        public EnumNivelJogadores NivelJogadores { get; set; } = EnumNivelJogadores.Medio;

        public bool PerfilPublico { get; set; } = false;
        public bool AceitaContra { get; set; } = false;
        public bool AceitaIntegrantes { get; set; } = false;

        public decimal ValorMensal { get; set; }
    }
}
