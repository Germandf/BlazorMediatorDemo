using BlazorMediatorDemo.Shared.Cqrs.Events;
using BlazorMediatorDemo.Shared.Services;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class UpdateTemperaturesHandler : INotificationHandler<MinuteHasChanged>
{
    private readonly ITemperatureService _temperatureService;

    public UpdateTemperaturesHandler(ITemperatureService temperatureService)
    {
        _temperatureService = temperatureService;
    }

    public Task Handle(MinuteHasChanged notification, CancellationToken cancellationToken)
    {
        _temperatureService.InsertTemperature(Random.Shared.Next(20, 30));
        return Task.CompletedTask;
    }
}
