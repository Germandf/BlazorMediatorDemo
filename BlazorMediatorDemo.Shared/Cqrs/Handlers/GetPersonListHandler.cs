using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.DataAccess;
using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
    private readonly IDataAccess _dataAccess;

    public GetPersonListHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataAccess.GetPeople());
    }
}
