namespace CAServer.Grains.State.Chain;

public class ChainState
{
    public string Id { get; set; }
    public string ChainId { get; set; }
    public string ChainName { get; set; }
    public string EndPoint { get; set; }
    public string ExplorerUrl { get; set; }
    public string CaContractAddress { get; set; }
    public DateTime LastModifyTime { get; set; }
    public bool IsDeleted { get; set; } = false;
}