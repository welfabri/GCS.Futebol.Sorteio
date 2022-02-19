using GCS.Futebol.Sorteio.Entidades.Classes.DTO;
using GCS.Futebol.Sorteio.Entidades.Classes.Modelos;
using GCS.Futebol.Sorteio.Entidades.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GCS.Futebol.Sorteio.API.V1.Controllers;

[ApiController]
[Route("[controller]")]
public class SorteioController : ControllerBase
{

    private readonly ILogger<SorteioController> _logger;
    private readonly IRepositorioAtleta _repositorioAtleta;

    public SorteioController(ILogger<SorteioController> logger,
        IRepositorioAtleta repositorioAtleta)
    {
        _logger = logger;
        _repositorioAtleta = repositorioAtleta;
    }

    [HttpGet(Name = "sortear")]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpPost(Name ="cadastrar-atleta")]
    public async Task<ActionResult<DTORetornoCadastrarAtleta>> CadastrarAtleta(DTOCadastrarAtleta dto)
    {
        if (dto is null)
            return BadRequest();

        try
        {
            Atleta atleta = new(dto);

            await _repositorioAtleta.CriarAsync(atleta);
            await _repositorioAtleta.UnityOfWork.CommitAsync();

            DTORetornoCadastrarAtleta result = new(atleta.Id, 
                atleta.Nome, atleta.Apelido, atleta.Nota, 
                atleta.PosicoesFormatadas.ToList());

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
