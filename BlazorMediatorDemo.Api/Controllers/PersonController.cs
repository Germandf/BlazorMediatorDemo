using BlazorMediatorDemo.Shared.Cqrs.Commands;
using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMediatorDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public PersonController(IMediator mediator) =>
        _mediator = mediator;

    [HttpGet]
    public async Task<List<Person>> Get() => 
        await _mediator.Send(new GetPersonListQuery());

    [HttpGet("{id}")]
    public async Task<Person?> Get(int id) => 
        await _mediator.Send(new GetPersonByIdQuery(id));

    [HttpPost]
    public async Task<Person> Post([FromBody] Person person) => 
        await _mediator.Send(new InsertPersonCommand(person.FirstName, person.LastName));
}
