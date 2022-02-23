using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMediatorDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemperatureController : ControllerBase
{
    private readonly IMediator _mediator;

    public TemperatureController(IMediator mediator) =>
        _mediator = mediator;

    [HttpGet]
    public async Task<List<Temperature>> Get() =>
        await _mediator.Send(new GetTemperatureListQuery());
}
