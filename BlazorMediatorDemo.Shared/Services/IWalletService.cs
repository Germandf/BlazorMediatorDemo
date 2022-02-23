using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.Services;

public interface IWalletService
{
    List<Wallet> GetWallets();
    Wallet InsertWallet(string owner, float amount);
}
