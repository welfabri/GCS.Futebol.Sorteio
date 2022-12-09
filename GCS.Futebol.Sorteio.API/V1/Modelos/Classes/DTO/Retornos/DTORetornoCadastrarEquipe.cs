namespace GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO.Retornos
{
    public class DTORetornoCadastrarEquipe
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;

        /// <summary>
        /// Usado para comunicações e para entrada no app
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }
}
