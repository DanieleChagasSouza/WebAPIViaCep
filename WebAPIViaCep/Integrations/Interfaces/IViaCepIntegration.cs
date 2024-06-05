using WebAPIViaCep.Models;

namespace WebAPIViaCep.Integrations.Interfaces;

public interface IViaCepIntegration
{
    Task<ViaCep> ObterDadosViaCepIntegration(string cep);
}
