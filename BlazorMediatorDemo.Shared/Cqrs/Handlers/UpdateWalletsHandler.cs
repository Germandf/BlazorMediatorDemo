using BlazorMediatorDemo.Shared.Cqrs.Events;
using BlazorMediatorDemo.Shared.Services;
using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Handlers;

public class UpdateWalletsHandler : INotificationHandler<MinuteHasChanged>
{
    private readonly IWalletService _walletService;

    public UpdateWalletsHandler(IWalletService wallerService)
    {
        _walletService = wallerService;
    }

    public Task Handle(MinuteHasChanged notification, CancellationToken cancellationToken)
    {
        var wallets = _walletService.GetWallets();
        var maxAmount = wallets.Max(x => x.Amount);
        _walletService.InsertWallet("German", maxAmount + Random.Shared.Next(100, 300));
        return Task.CompletedTask;
    }
}
