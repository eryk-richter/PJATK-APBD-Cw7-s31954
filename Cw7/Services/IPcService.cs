using Cw7.DTOs;
using Cw7.Infrastructure;

namespace Cw7.Services;

public interface IPcService
{
    public Task<IEnumerable<PcDto>> GetAllAync(CancellationToken cancellationToken);
    public Task<PcDetailsDto> GetComponentsByPcIdAsync(int pcId, CancellationToken cancellationToken);
    public Task<PcDto> AddPcAsync(CreatePcRequestDto request, CancellationToken cancellationToken);
    
    public Task UpdatePcAsync(int pcId, UpdatePcRequestDto request, CancellationToken cancellationToken);
    public Task DeletePcAsync(int pcId, CancellationToken cancellationToken);
}