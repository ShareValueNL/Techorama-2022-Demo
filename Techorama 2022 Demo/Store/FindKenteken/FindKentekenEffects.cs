using System.Text.Json;
using Fluxor.Persist.Storage;
using SV.Techorama.Services.Interfaces;

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
        var rdwModel = await _rdwService.FindKenteken(action.Kenteken);
        if (rdwModel is null)
        {
            dispatcher.Dispatch(new FindKentekenErrorAction("License plate could not be found!"));
        }
        else
        {
            dispatcher.Dispatch(new KentekenFoundAction(rdwModel));
        }
    }
}

public class ReloadKentekenInfoEffect : Effect<ReloadKentekenInfoAction>
{
    private readonly IStringStateStorage _stringStateStorage;

    public ReloadKentekenInfoEffect(IStringStateStorage stringStateStorage)
    {
        _stringStateStorage = stringStateStorage;
    }
    
    public override async Task HandleAsync(ReloadKentekenInfoAction action, IDispatcher dispatcher)
    {
        var jsonString = await _stringStateStorage.GetStateJsonAsync(nameof(FindKentekenState));
        if (!string.IsNullOrWhiteSpace(jsonString))
        {
            var state = JsonSerializer.Deserialize<FindKentekenState>(jsonString);
            if (state != null)
            {
                dispatcher.Dispatch(new ReloadKentekenInfoSuccessAction(state));
            }
        }
    }
}