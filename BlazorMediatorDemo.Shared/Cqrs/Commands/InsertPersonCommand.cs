using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Commands;

public record InsertPersonCommand(string FirstName, string LastName) : IRequest<Person>;
