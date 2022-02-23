using BlazorMediatorDemo.Shared.Cqrs.Queries;
using BlazorMediatorDemo.Shared.Models;
using BlazorMediatorDemo.Shared.Services;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class GetWalletListHandler : IRequestHandler<GetWalletListQuery, List<Wallet>>
{
    private readonly IWalletService _walletService;

    public GetWalletListHandler(IWalletService walletService)
    {
        _walletService = walletService;
    }

    public Task<List<Wallet>> Handle(GetWalletListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_walletService.GetWallets());
    }
}
