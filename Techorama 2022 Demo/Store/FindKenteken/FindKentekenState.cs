using SV.Techorama.Models;

namespace SV.Techorama.Store.FindKenteken;

[FeatureState(Name = nameof(FindKentekenState))]
public record FindKentekenState
{
    public string Kenteken { get; init; } = null!;

    public bool? Loading { get; init; } = false;

    public string? ErrorMessage { get; init; }
    
    public RdwModel? RdwModel { get; init; } 
    
    public FindKentekenState () { }
    
}

// 

// public class FindKentekenFeature : Feature<FindKentekenState>
// {
//     public override string GetName()
//     {
//         return nameof(FindKentekenState);
//     }
//
//     protected override FindKentekenState GetInitialState()
//     {
//         return new FindKentekenState
//         {
//             Kenteken = string.Empty,
//             Loading = false,
//             ErrorMessage = null,
//             RdwModel = null
//         };
//     }
// }