using SV.Techorama.Models;
using SV.Techorama.Services.Interfaces;

namespace SV.Techorama.Services;

public class RdwService : IRdwService
{
    private const string RdwUrl = "RdwUrl";
    private const string KentekenParameter = "kenteken";
    
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    public RdwService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task<RdwModel?> FindKenteken(string kenteken)
    {
        var httpClient = _httpClientFactory.CreateClient();
        var url = _configuration.GetValue<string>(RdwUrl);
        var uri = $"{url}?{KentekenParameter}={kenteken}";
        
        var result = await httpClient.GetFromJsonAsync<RdwModel[]>(uri);
        return result?.SingleOrDefault();
    }
}