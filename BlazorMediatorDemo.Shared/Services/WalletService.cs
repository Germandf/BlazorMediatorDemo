using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.Services;

public class WalletService : IWalletService
{
    private List<Wallet> _wallet = new();

    public WalletService()
    {
        _wallet.Add(new() { Id = 1, Owner = "German", Amount = 200 });
        _wallet.Add(new() { Id = 2, Owner = "German", Amount = 350 });
    }

    public List<Wallet> GetWallets()
    {
        return _wallet;
    }

    public Wallet InsertWallet(string owner, float amount)
    {
        var wallet = new Wallet() { Owner = owner, Amount = amount };
        wallet.Id = _wallet.Max(x => x.Id) + 1;
        _wallet.Add(wallet);
        return wallet;
    }
}
