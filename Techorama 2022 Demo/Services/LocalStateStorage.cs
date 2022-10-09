using Blazored.LocalStorage;
using Fluxor.Persist.Storage;

namespace SV.Techorama.Services;

public class LocalStateStorage : IStringStateStorage
{
    private readonly ILocalStorageService _localStorage;

    public LocalStateStorage(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }
    
    public async ValueTask<string> GetStateJsonAsync(string statename)
    {
        return await _localStorage.GetItemAsStringAsync(statename);
    }

    public async ValueTask StoreStateJsonAsync(string statename, string json)
    {
        await _localStorage.SetItemAsStringAsync(statename, json);
    }
}