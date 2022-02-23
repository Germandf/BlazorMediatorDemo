using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Queries;

public record GetPersonByIdQuery(int Id) : IRequest<PersonModel?>;
