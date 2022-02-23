using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMediatorDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WalletController : ControllerBase
{
    private readonly IMediator _mediator;

    public WalletController(IMediator mediator) =>
        _mediator = mediator;

    [HttpGet]
    public async Task<List<Wallet>> Get() =>
        await _mediator.Send(new GetWalletListQuery());
}
