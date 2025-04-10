using BlazorApp1.Data.Models;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AsuntosController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AsuntosController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Asunto>>> GetAsuntos()
    {
        return await _context.Asuntos.ToListAsync();
    }
}