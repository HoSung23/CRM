using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Data.Services
{
    public class RegistroService : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RegistroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateEstado(int id, string nuevoEstado)
        {
            var registro = await _context.Registros.FindAsync(id);
            if (registro == null)
            {
                throw new Exception("Registro no encontrado");
            }
            registro.Estado = nuevoEstado;
            await _context.SaveChangesAsync();
        }
    }
}
