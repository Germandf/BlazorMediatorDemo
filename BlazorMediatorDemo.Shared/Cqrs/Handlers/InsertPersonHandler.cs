using BlazorMediatorDemo.Shared.Cqrs.Commands;
using BlazorMediatorDemo.Shared.DataAccess;
using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _dataAccess;

        public InsertPersonHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
