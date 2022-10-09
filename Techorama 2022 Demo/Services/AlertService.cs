using SV.Techorama.Models;
using SV.Techorama.Services.Interfaces;

namespace SV.Techorama.Services;

public class AlertService : IAlertService
{
    private const string DefaultId = "default-alert";
    public event Action<Alert>? OnAlert;

    public void Success(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        Alert(new Alert
        {
            Type = AlertType.Success,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Error(string message, bool keepAfterRouteChange = false, bool autoClose = false)
    {
        Alert(new Alert
        {
            Type = AlertType.Error,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Info(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        Alert(new Alert
        {
            Type = AlertType.Info,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Warn(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        Alert(new Alert
        {
            Type = AlertType.Warning,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Alert(Alert alert)
    {
        OnAlert?.Invoke(alert);
    }

    public void Clear(string? id = DefaultId)
    {
        OnAlert?.Invoke(new Alert { Id = id! });
    }
}
