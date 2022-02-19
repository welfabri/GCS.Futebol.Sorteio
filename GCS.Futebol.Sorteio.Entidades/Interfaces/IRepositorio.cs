namespace GCS.Futebol.Sorteio.Entidades.Interfaces
{
    public interface IRepositorio<T> : IDisposable
        where T : IAggregateRoot
    {
    }
}