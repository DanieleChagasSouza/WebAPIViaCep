using Microsoft.AspNetCore.Mvc;
using WebAPIViaCep.Integrations.Interfaces;
using WebAPIViaCep.Models;

namespace WebAPIViaCep.Controllers;

public class ViaCepController: ControllerBase
{
    private readonly IViaCepIntegration _viaCepIntegration;

    public ViaCepController(IViaCepIntegration viaCepIntegration)
    {
        _viaCepIntegration = viaCepIntegration;
    }

    [HttpGet("{cep}")]
    public async Task<ActionResult<ViaCep>> ListardadosdeEndereco(string cep)
    {
        var response = await _viaCepIntegration.ObterDadosViaCepIntegration(cep);
        if (response == null)
        {
            return BadRequest("CEP não encontrado!");
        }
        return Ok(response);
    }
}
