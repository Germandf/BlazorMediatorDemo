using BlazorMediatorDemo.Shared.Cqrs.Commands;
using BlazorMediatorDemo.Shared.Services;
using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Person>
    {
        private readonly IPersonService _personService;

        public InsertPersonHandler(IPersonService dataAccess)
        {
            _personService = dataAccess;
        }

        public Task<Person> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_personService.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
