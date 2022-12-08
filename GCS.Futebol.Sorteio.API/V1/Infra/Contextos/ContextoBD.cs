using LiteDB;

namespace GCS.Futebol.Sorteio.API.V1.Infra.Contextos;

public class ContextoBD
{
    private static LiteDatabase? _bd = null;

    public static LiteDatabase CriarBD(string nome = "gcsfutebolsorteio.dblite")
    {
        if (_bd is null)
            _bd = new($"{nome}");

        return _bd;
    }
}
