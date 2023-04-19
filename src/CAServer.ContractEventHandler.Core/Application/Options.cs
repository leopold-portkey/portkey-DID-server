using System.Collections.Generic;

namespace CAServer.ContractEventHandler.Core.Application;

public class ChainOptions
{
    public Dictionary<string, ChainInfo> ChainInfos { get; set; }
}

public class ChainInfo
{
    public string ChainId { get; set; }
    public string BaseUrl { get; set; }
    public string ContractAddress { get; set; }
    public string TokenContractAddress { get; set; }
    public string CrossChainContractAddress { get; set; }
    public string PrivateKey { get; set; }
    public bool IsMainChain { get; set; }
}

public class IndexOptions
{
    public int IndexDelay { get; set; }
    public long IndexInterval { get; set; }
    public long IndexSafe { get; set; }
    public long IndexTimes { get; set; }
}

public class GraphQLOptions
{
    public string GraphQLConnection { get; set; }
}

public class ContractSyncOptions
{
    public string Cron { get; set; }
}