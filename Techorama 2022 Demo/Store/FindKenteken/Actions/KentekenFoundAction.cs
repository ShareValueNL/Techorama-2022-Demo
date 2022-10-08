using SV.Techorama.Models;

namespace SV.Techorama.Store.FindKenteken.Actions;

public record KentekenFoundAction
{
    
    public RdwModel RdwModel { get; init; }
}