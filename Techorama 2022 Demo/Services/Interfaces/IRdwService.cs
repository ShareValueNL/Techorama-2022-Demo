using SV.Techorama.Models;

namespace SV.Techorama.Services.Interfaces;

public interface IRdwService
{
    Task<RdwModel?> FindKenteken(string kenteken);

}