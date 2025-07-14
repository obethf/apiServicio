using Microsoft.AspNetCore.Mvc;
using apiServicio.Data;
using apiServicio.Models;
using Microsoft.EntityFrameworkCore;

namespace apiServicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly ProgramacionWebIIContext _context;

        public EstudiantesController(ProgramacionWebIIContext context)
        {
            _context = context;
        }

        // GET: api/estudiantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstudianteDTO>>> GetEstudiantesPorRol()
        {
            var estudiantes = await _context.Estudiantes
                .Where(e => e.Rol == "Estudiante") // Filtrar solo estudiantes
                .Select(e => new EstudianteDTO     // Proyectar en el DTO
                {
                    Id = e.Id,
                    NombreCompleto = e.NombreCompleto
                })
                .ToListAsync();

            return Ok(estudiantes); // Devuelve la lista como JSON
        }
    }
}
