using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.Services;

public class TemperatureService : ITemperatureService
{
    private List<Temperature> _temperatures = new();

    public TemperatureService()
    {
        _temperatures.Add(new() { Id = 1, TemperatureC = 25 });
        _temperatures.Add(new() { Id = 2, TemperatureC = 27 });
    }

    public List<Temperature> GetTemperatures()
    {
        return _temperatures;
    }

    public Temperature InsertTemperature(int temperatureC)
    {
        var temperature = new Temperature() { TemperatureC = temperatureC };
        temperature.Id = _temperatures.Max(x => x.Id) + 1;
        _temperatures.Add(temperature);
        return temperature;
    }
}
