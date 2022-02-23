using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.Services;

public interface ITemperatureService
{
    List<Temperature> GetTemperatures();
    Temperature InsertTemperature(int temperatureC);
}
