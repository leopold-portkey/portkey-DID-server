using System.Security.Cryptography;
using AElf;
using AElf.Cryptography;
using CAServer.Grains.State.RedPackage;
using Orleans.Providers.Streams.Generator;

namespace CAServer.Grains.Grain.RedPackage;

public class RedPackageKeyGrain : Orleans.Grain<RedPackageKeyState>, IRedPackageKeyGrain
{
    public override async Task OnActivateAsync()
    {
        await ReadStateAsync();
        await base.OnActivateAsync();
    }

    public override async Task OnDeactivateAsync()
    {
        await WriteStateAsync();
        await base.OnDeactivateAsync();
    }

    public async Task<string> GenerateKey()
    {
        var keyPair = CryptoHelper.GenerateKeyPair();
        State.PublicKey = keyPair.PublicKey.ToHex();
        State.PrivateKey = keyPair.PrivateKey.ToHex();
        await WriteStateAsync();
        return State.PublicKey;
    }
    
    public Task<string> GenerateSignature(string input)
    {
        var hashByteArray = HashHelper.ComputeFrom(input).ToByteArray();
        var signature =
            CryptoHelper.SignWithPrivateKey(ByteArrayHelper.HexStringToByteArray(State.PrivateKey), hashByteArray);
        return Task.FromResult(signature.ToHex());
    }
}