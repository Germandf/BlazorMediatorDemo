using BlazorMediatorDemo.Shared.Cqrs.Events;
using MediatR;

namespace BlazorMediatorDemo.Api.Services.Hosted;

public class MinuteHasChangeNotificationService : BackgroundService
{
    private readonly IMediator _mediator;

    public MinuteHasChangeNotificationService(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await _mediator.Publish(new MinuteHasChanged());
            await Task.Delay(60000, stoppingToken);
        }
    }
}
