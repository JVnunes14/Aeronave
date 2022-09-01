using VoeAirlines.Services;
using VoeAirlines.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace VoeAirlines.Controllers;

[Route("api/aeronaves")]
[ApiController]
public class AeronaveController : ControllerBase
{
    private readonly AeronaveServices  _aeronaveService;

    public AeronaveController(AeronaveServices aeronaveService)
    {
        _aeronaveService = aeronaveService;
    }

    [HttpPost]
    public IActionResult AdicionarAeronave(AdicionarAeronaveViewModels dados)
    {
        var aeronave = _aeronaveService.AdicionarAeronave(dados);
        return Ok(aeronave);
    }

    [HttpGet]
    public IActionResult ListarAeronave(){
        return Ok(_aeronaveService.ListarAeronave());
    }

    /*[HttpGet]
    public IActionResult ListarAeronaves()
    {
        return Ok(_aeronaveService.ListarAeronaves());
    }*/

  /*  [HttpGet("{id}")]
    public IActionResult ListarAeronavePeloId(int id)
    {
        var aeronave = _aeronaveService.ListarAeronavePeloId(id);

        if(aeronave != null)
        {
            return Ok(aeronave);
        }

        return NotFound();
    }*/

   /* [HttpPut("{id}")]
    public IActionResult AtualizarAeronave(int id, AtualizarAeronaveViewModels dados)
    {
        if (id != dados.Id)
            return BadRequest("O id informado na URL é diferente do id informado no corpo da requisição.");

        var aeronave = _aeronaveService.AtualizarAeronave(dados);
        return Ok(aeronave);
    }*/

  /*  [HttpDelete("{id}")]
    public IActionResult ExcluirAeronave(int id)
    {
        _aeronaveService.ExcluirAeronave(id);
        return NoContent();
    }*/
}