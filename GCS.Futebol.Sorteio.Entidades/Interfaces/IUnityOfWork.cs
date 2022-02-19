namespace GCS.Futebol.Sorteio.Entidades.Interfaces
{
    public interface IUnityOfWork
    {
        Task<bool> CommitAsync();
    }
}
