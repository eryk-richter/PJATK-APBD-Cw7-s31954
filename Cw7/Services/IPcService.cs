using Cw7.DTOs;
using Cw7.Infrastructure;

namespace Cw7.Services;

public interface IPcService
{
    public Task<IEnumerable<PcDto>> getAllAync(CancellationToken cancellationToken);
    public Task<PcDetailsDto> GetComponentsByPcIdAsync(int pcId, CancellationToken cancellationToken);

}