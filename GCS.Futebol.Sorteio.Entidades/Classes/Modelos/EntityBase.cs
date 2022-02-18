namespace GCS.Futebol.Sorteio.Entidades.Classes.Modelos;

public abstract class EntityBase
{
    public EntityBase() => Id = Guid.NewGuid();

    protected EntityBase(Guid id) => Id = id;

    public Guid Id { get; private set; }
}
