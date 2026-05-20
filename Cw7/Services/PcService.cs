using Cw7.DTOs;
using Cw7.Exceptions;
using Cw7.Infrastructure;
using Cw7.Models;
using Microsoft.EntityFrameworkCore;

namespace Cw7.Services;

public class PcService (DatabaseContext ctx) : IPcService
{
    public async Task<IEnumerable<PcDto>> GetAllAync(CancellationToken cancellationToken)
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


    public async Task<PcDetailsDto> GetComponentsByPcIdAsync(int pcId, CancellationToken cancellationToken)
    {
        var details =  await ctx.Pcs.Where(p => p.Id == pcId)
            .Select(p => new PcDetailsDto(
                p.Id,
                p.Name,
                p.Weight,
                p.Warranty,
                p.CreatedAt,
                p.Stock,
                p.PcComponents.Select(pcc => new PcComponentDto(
                    pcc.Amount,
                    new ComponentDto(
                        pcc.Component.Code,
                        pcc.Component.Name,
                        pcc.Component.Description,
                        new ManufacturerDto(
                            pcc.Component.ComponentManufacturer.Id,
                            pcc.Component.ComponentManufacturer.Abbreviation,
                            pcc.Component.ComponentManufacturer.FullName,
                            pcc.Component.ComponentManufacturer.FoundationDate
                        ),
                        new TypeDto(
                            pcc.Component.ComponentType.Id,
                            pcc.Component.ComponentType.Abbreviation,
                            pcc.Component.ComponentType.Name
                            
                        )
                    )
                ))
            )).FirstOrDefaultAsync(cancellationToken);
        
        return details ?? throw new PcNotFoundException("Pc " + pcId + " not found");

    }

    public async Task<PcDto> AddPcAsync(CreatePcRequestDto request, CancellationToken cancellationToken)
    {
        var pc = new Pc
        {
            Name = request.Name,
            Weight = request.Weight,
            Warranty = request.Warranty,
            CreatedAt = request.CreatedAt,
            Stock = request.Stock
        };
        
        ctx.Add(pc);
        await ctx.SaveChangesAsync(cancellationToken);
        
        return new PcDto(pc.Id, pc.Name, pc.Weight, pc.Warranty, pc.CreatedAt, pc.Stock);
    }
}