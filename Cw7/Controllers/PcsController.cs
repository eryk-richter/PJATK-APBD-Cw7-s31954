using Cw7.Models;
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
        
        return Ok(await service.getAllAync(cancellationToken));
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Add()
    {
        return Ok();
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id)
    {
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        return Ok();
    }
    
    
}