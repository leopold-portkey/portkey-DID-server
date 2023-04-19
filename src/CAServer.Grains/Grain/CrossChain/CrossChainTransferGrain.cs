using CAServer.Grains.State.CrossChain;
using Orleans;
using Volo.Abp.ObjectMapping;

namespace CAServer.Grains.Grain.CrossChain;

public class CrossChainTransferGrain : Orleans.Grain<CrossChainTransferState>, ICrossChainTransferGrain
{
    private readonly IObjectMapper _objectMapper;

    public CrossChainTransferGrain(IObjectMapper objectMapper)
    {
        _objectMapper = objectMapper;
    }

    public async Task<GrainResultDto<List<CrossChainTransferDto>>> GetUnFinishedTransfersAsync()
    {
        var list = _objectMapper.Map<List<CrossChainTransfer>, List<CrossChainTransferDto>>(State.CrossChainTransfers
            .Values.ToList());

        return new GrainResultDto<List<CrossChainTransferDto>>
        {
            Data = list
        };
    }

    public async Task<GrainResultDto<long>> GetLastedProcessedHeightAsync()
    {
        return new GrainResultDto<long> { Data = State.LastedProcessedHeight };
    }

    public async Task AddTransfersAsync(long lastedHeight, List<CrossChainTransferDto> transfers)
    {
        foreach (var transfer in transfers)
        {
            var record = _objectMapper.Map<CrossChainTransferDto, CrossChainTransfer>(transfer);
            State.CrossChainTransfers.TryAdd(record.Id, record);
        }

        State.LastedProcessedHeight = lastedHeight;
        await WriteStateAsync();
    }

    public async Task UpdateTransferAsync(CrossChainTransferDto transfer)
    {
        if (transfer.Status == CrossChainStatus.Confirmed)
        {
            State.CrossChainTransfers.Remove(transfer.Id);
        }
        else
        {
            var record = _objectMapper.Map<CrossChainTransferDto, CrossChainTransfer>(transfer);
            State.CrossChainTransfers[record.Id] = record;
        }
        
        await WriteStateAsync();
    }
    
    public override async Task OnActivateAsync()
    {
        await ReadStateAsync();
        await base.OnActivateAsync();
    }
}