using Cw7.DTOs;
using Cw7.Exceptions;
using Cw7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cw7.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class PcsController(IPcService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        
        return Ok(await service.GetAllAync(cancellationToken));
    }
    
    [HttpGet("{id:int}/components")]
    public async Task<IActionResult> GetById([FromRoute] int id,  CancellationToken cancellationToken)
    {
        try
        {
            return Ok(await service.GetComponentsByPcIdAsync(id, cancellationToken));
        }
        catch (PcNotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePcRequestDto request, CancellationToken cancellationToken)
    {
        var pc = await service.AddPcAsync(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = pc.Id }, pc);
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePcRequestDto request, CancellationToken cancellationToken)
    {
        try
        {
            await service.UpdatePcAsync(id, request, cancellationToken);
            return NoContent();
        } 
        catch (PcNotFoundException e)
        {
            return NotFound(e.Message);
        }
        
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        return Ok();
    }
    
    
}