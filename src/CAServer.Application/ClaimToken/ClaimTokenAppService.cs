using System;
using System.Linq;
using System.Threading.Tasks;
using CAServer.Cache;
using CAServer.ClaimToken.Dtos;
using CAServer.Common;
using CAServer.Options;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace CAServer.ClaimToken;

public class ClaimTokenAppService : IClaimTokenAppService, ISingletonDependency
{
    private readonly ClaimTokenWhiteListAddressesOptions _claimTokenWhiteListAddressesOptions;
    private readonly IContractProvider _contractProvider;
    private readonly ICacheProvider _cacheProvider;
    private readonly ClaimTokenInfoOptions _claimTokenInfoOption;
    private const string GetClaimTokenAddressCacheKey = "GetClaimTokenAddress :";


    public ClaimTokenAppService(
        IOptionsSnapshot<ClaimTokenWhiteListAddressesOptions> claimTokenWhiteListAddressesOptions,
        IContractProvider contractProvider, ICacheProvider cacheProvider,
        IOptionsSnapshot<ClaimTokenInfoOptions> claimTokenInfoOptions)
    {
        _contractProvider = contractProvider;
        _cacheProvider = cacheProvider;
        _claimTokenInfoOption = claimTokenInfoOptions.Value;
        _claimTokenWhiteListAddressesOptions = claimTokenWhiteListAddressesOptions.Value;
    }

    public async Task<ClaimTokenResponseDto> GetClaimTokenAsync(ClaimTokenRequestDto claimTokenRequestDto)
    {
        var cacheClaimToken = await _cacheProvider.Get(GetClaimTokenAddressCacheKey + claimTokenRequestDto.Address);
        if (int.TryParse(cacheClaimToken, out var count))
        {
            if (count >= _claimTokenInfoOption.GetClaimTokenLimit)
            {
                throw new UserFriendlyException("Today's limit has been reached.");
            }
        }

        var address = _claimTokenWhiteListAddressesOptions.WhiteListAddresses.FirstOrDefault();
        if (address.IsNullOrWhiteSpace())
        {
            throw new UserFriendlyException("No available address");
        }

        var chainId = _claimTokenInfoOption.ChainId;
        var getBalanceOutput = await _contractProvider.GetBalanceAsync(chainId, address, claimTokenRequestDto.Symbol);
        if (getBalanceOutput.Balance < _claimTokenInfoOption.ClaimTokenAmount)
        {
            await _contractProvider.ClaimTokenAsync(chainId, claimTokenRequestDto.Symbol);
        }

        var result = await _contractProvider.TransferAsync(chainId, claimTokenRequestDto);
        await _cacheProvider.Increase(GetClaimTokenAddressCacheKey + claimTokenRequestDto.Address, 1,
            TimeSpan.FromHours(_claimTokenInfoOption.ExpireTime));
        return new ClaimTokenResponseDto
        {
            TransactionId = result.TransactionId
        };
    }
}