using GCS.Futebol.Sorteio.Entidades.Classes.DTO;
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

    [HttpGet(Name = "sortear")]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpPost(Name ="cadastrar-atleta")]
    public ActionResult<DTORetornoCadastrarAtleta> CadastrarAtleta(DTOCadastrarAtleta dto)
    {
        if (dto is null)
            return BadRequest();

        //Chamar serviço responsável por gravar no banco
        DTORetornoCadastrarAtleta result = new(Guid.NewGuid(), dto.Nome, dto.Apelido, dto.Nota, dto.Posicoes);

        return Ok(result);
    }
}
