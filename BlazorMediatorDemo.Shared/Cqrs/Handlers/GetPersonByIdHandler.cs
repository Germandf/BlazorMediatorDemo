using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Services;
using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person?>
{
    private readonly IPersonService _personService;

    public GetPersonByIdHandler(IPersonService dataAccess)
    {
        _personService = dataAccess;
    }

    public Task<Person?> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_personService.GetPerson(request.Id));
    }
}
