using BlazorApp1.Data.Models;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class RegistrosController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public RegistrosController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Registros>>> GetRegistros()
    {
        return await _context.Registros.ToListAsync();
    }

    [HttpPut("{id}/estado")]
    public async Task<IActionResult> UpdateEstado(int id, [FromBody] string nuevoEstado)
    {
        var registro = await _context.Registros.FindAsync(id);
        if (registro == null)
        {
            return NotFound();
        }

        registro.Estado = nuevoEstado;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}