using BlazorMediatorDemo.Shared.Models;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Queries;

public record GetWalletListQuery() : IRequest<List<Wallet>>;
