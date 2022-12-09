using GCS.Futebol.Sorteio.API.V1.Infra.Contextos;
using GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO;
using GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO.Parametros;
using GCS.Futebol.Sorteio.API.V1.Modelos.Classes.DTO.Retornos;
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
    [HttpPost("cadastrar-equipe")]
    public ActionResult<DTORetornoCadastrarEquipe> CadastrarTurma(DTOCadastrarEquipe dto)
    {
        if (dto is null)
            return BadRequest();

        try
        {
            CadastroEquipe equipe = new(dto);

            using (var bd = ContextoBD.CriarBD())
            {
                var id = bd.GetCollection<CadastroEquipe>().Insert(equipe);
                bd.Commit();

                DTORetornoCadastrarEquipe result = new(id,
                    equipe.Nome, equipe.Apelido, equipe.Nota,
                    equipe.PosicoesFormatadas.ToList());

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
    public ActionResult<DTORetornoCadastrarJogador> CadastrarAtleta(DTOCadastrarJogador dto)
    {
        if (dto is null)
            return BadRequest();

        try
        {
            Jogador atleta = new(dto);
            
            using (var bd = ContextoBD.CriarBD())
            {
                var id = bd.GetCollection<Jogador>().Insert(atleta);
                bd.Commit();

                DTORetornoCadastrarJogador result = new(id,
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
