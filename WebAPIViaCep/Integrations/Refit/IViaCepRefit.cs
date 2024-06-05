using Refit;
using WebAPIViaCep.Models;

namespace WebAPIViaCep.Integrations.Refit;

public interface IViaCepRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCep>> ObterDadosViaCep(string cep);
}
