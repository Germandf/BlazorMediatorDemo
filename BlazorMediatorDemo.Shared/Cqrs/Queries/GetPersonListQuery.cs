using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Queries;

public record GetPersonListQuery() : IRequest<List<Person>>;
