using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Services;
using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
{
    private readonly IPersonService _personService;

    public GetPersonListHandler(IPersonService dataAccess)
    {
        _personService = dataAccess;
    }

    public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_personService.GetPeople());
    }
}
