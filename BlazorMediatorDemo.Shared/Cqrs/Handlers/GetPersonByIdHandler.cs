using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.DataAccess;
using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel?>
{
    private readonly IDataAccess _dataAccess;

    public GetPersonByIdHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public Task<PersonModel?> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataAccess.GetPerson(request.Id));
    }
}
