using GCS.Futebol.Sorteio.API.V1.Infra.Contextos;
using GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO;
using GCS.Futebol.Sorteio.API.V1.Modelos.Classes.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace GCS.Futebol.Sorteio.API.V1.Controllers;

[ApiController]
[Route("[controller]")]
public class SorteioController : ControllerBase
{

    private readonly ILogger<SorteioController> _logger;

    public SorteioController(ILogger<SorteioController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sortear")]
    public IActionResult Get(int codigoTurma, short numeroAtletasPorTime, List<int> listaAtletas)
    {
        return Ok();
    }

    /*
    [HttpPost("cadastrar-turma")]
    public ActionResult<DTORetornoCadastrarTurma> CadastrarTurma(DTOCadastrarTurma dto)
    {
        if (dto is null)
            return BadRequest();

        try
        {
            CadastroTurma turma = new(dto);

            using (var bd = ContextoBD.CriarBD())
            {
                var id = bd.GetCollection<CadastroTurma>().Insert(turma);
                bd.Commit();

                DTORetornoCadastrarTurma result = new(id,
                    turma.Nome, turma.Apelido, turma.Nota,
                    turma.PosicoesFormatadas.ToList());

                return Ok(result);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    */

    /*
    [HttpPost("salvar-sorteio")]
    public IActionResult SalvarSorteio(int codigoTurma, DTOSalvarSorteio listaSorteio)
    {
        return Ok();
    }
    */

    /*
    [HttpPost("listar-atletas")]
    public ActionResult<DTORetornoListarAtletas> ListarAtletas(int codigoTurma)
    {
        if (dto is null)
            return BadRequest();

        try
        {
            using (var bd = ContextoBD.CriarBD())
            {
                var atletas = bd.GetCollection<Atleta>().Find(x => x.IdTurma == codigoTurma);
                DTORetornoListarAtletas result = new(atletas);

                return Ok(result);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    */

    [HttpPost("cadastrar-atleta")]
    public ActionResult<DTORetornoCadastrarAtleta> CadastrarAtleta(DTOCadastrarAtleta dto)
    {
        if (dto is null)
            return BadRequest();

        try
        {
            Atleta atleta = new(dto);
            
            using (var bd = ContextoBD.CriarBD())
            {
                var id = bd.GetCollection<Atleta>().Insert(atleta);
                bd.Commit();

                DTORetornoCadastrarAtleta result = new(id,
                    atleta.Nome, atleta.Apelido, atleta.Nota,
                    atleta.PosicoesFormatadas.ToList());

                return Ok(result);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
