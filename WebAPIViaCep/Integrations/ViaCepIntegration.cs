using WebAPIViaCep.Integrations.Interfaces;
using WebAPIViaCep.Integrations.Refit;
using WebAPIViaCep.Models;

namespace WebAPIViaCep.Integrations;

public class ViaCepIntegration : IViaCepIntegration
{
    private readonly IViaCepRefit _viaCepRefit;

    public ViaCepIntegration(IViaCepRefit viaCepRefit)
    {
        _viaCepRefit = viaCepRefit;
    }

    public async Task<ViaCep> ObterDadosViaCepIntegration(string cep)
    {
        var responseData = await _viaCepRefit.ObterDadosViaCep(cep);
        if(responseData != null && responseData.IsSuccessStatusCode) {

            return responseData.Content;
        
        }

        return null;
    }
}
