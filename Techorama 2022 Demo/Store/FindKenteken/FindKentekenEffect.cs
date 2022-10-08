using SV.Techorama.Models;
using SV.Techorama.Services.Interfaces;
using SV.Techorama.Store.FindKenteken.Actions;

namespace SV.Techorama.Store.FindKenteken;

public class FindKentekenEffect : Effect<FindKentekenAction>
{
    private readonly IRdwService _rdwService;

    public FindKentekenEffect(IRdwService rdwService)
    {
        _rdwService = rdwService;
    }

    public override async Task HandleAsync(FindKentekenAction action, IDispatcher dispatcher)
    {
        // action.Kenteken;
        var rdwModel = new RdwModel();
        
        dispatcher.Dispatch(new KentekenFoundAction() { RdwModel = rdwModel});
    }
}