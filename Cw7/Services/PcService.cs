using Cw7.DTOs;
using Cw7.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Cw7.Services;

public class PcService (DatabaseContext ctx) : IPcService
{
    public async Task<IEnumerable<PcDto>> getAllAync(CancellationToken cancellationToken)
    {
        return await ctx.Pcs.Select(pc => new PcDto(
            pc.Id,
            pc.Name,
            pc.Weight,
            pc.Warranty,
            pc.CreatedAt,
            pc.Stock
        )).ToListAsync(cancellationToken);
    }


}