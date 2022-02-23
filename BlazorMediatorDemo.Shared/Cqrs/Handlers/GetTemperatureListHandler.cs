using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Models;
using BlazorMediatorDemo.Shared.Services;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class GetTemperatureListHandler : IRequestHandler<GetTemperatureListQuery, List<Temperature>>
{
    private readonly ITemperatureService _temperatureService;

    public GetTemperatureListHandler(ITemperatureService temperatureService)
    {
        _temperatureService = temperatureService;
    }

    public Task<List<Temperature>> Handle(GetTemperatureListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_temperatureService.GetTemperatures());
    }
}
