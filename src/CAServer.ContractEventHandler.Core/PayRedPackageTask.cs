using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using CAServer.ContractEventHandler.Core.Application;
using CAServer.Grains.Grain.RedPackage;
using CAServer.RedPackage;
using CAServer.RedPackage.Etos;
using CAServer.Signature;
using Elasticsearch.Net;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orleans;
using Orleans.Runtime;
using IContractProvider = CAServer.Common.IContractProvider;

namespace CAServer.ContractEventHandler.Core;


public interface IPayRedPackageTask
{
    public Task PayRedPackageAsync(RedPackageCreateEto input);
}

public class PayRedPackageTask : IPayRedPackageTask
{
    private readonly IClusterClient _clusterClient;
    private readonly ILogger<PayRedPackageTask> _logger;
    private readonly IContractProvider _contractProvider;
    private readonly PayRedPackageAccount _packageAccount;
    

    public PayRedPackageTask(IClusterClient clusterClient, ILogger<PayRedPackageTask> logger, 
         IOptionsSnapshot<PayRedPackageAccount> packageAccount, IContractProvider contractProvider)
    {
        _clusterClient = clusterClient;
        _logger = logger;
        _packageAccount = packageAccount.Value;
        _contractProvider = contractProvider;
    }

    //[Queue("redpackage")]
    public async Task PayRedPackageAsync(RedPackageCreateEto input)
    {
        _logger.Info("PayRedPackageAsync start and the redpackage id is {}",input.RedPackageId);
        var grabItems = input.Items;
        //if we need judge other params ?
        if (grabItems.IsNullOrEmpty())
        {
            throw new Exception("there are no one claim the red packages");
        }
        var grain = _clusterClient.GetGrain<RedPackageGrain>(input.RedPackageId);
        foreach (var item in grabItems)
        {
            //get one our account，pay aelf to user’s account 
            var payRedPackageFrom = _packageAccount.getOneAccountRandom();
        
            //red package transaction
            var result = await _contractProvider.SendTransferAsync(input.Symbol,item.Amount.ToString(),
                item.CaAddress,input.ChainId,payRedPackageFrom);
            
            //if success update the payment status of red package 
            // var grain = _clusterClient.GetGrain<RedPackageGrain>(input.RedPackageId);
            await grain.UpdateRedPackage(input.RedPackageId, item.UserId, item.CaAddress);
        }
        _logger.Info("PayRedPackageAsync end and the redpackage id is {}",input.RedPackageId);

    }
    
    

}