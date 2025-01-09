using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GastosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GastosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GastosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("filtrar")]
        public async Task<IActionResult> FiltrarGastos(DateTime fechaInicio, DateTime fechaFin)
        {
            var gastos = await _context.Gastos
                .Where(g => g.Fecha >= fechaInicio && g.Fecha <= fechaFin)
                .GroupBy(g => g.DepartamentoID)
                .Select(g => new
                {
                    Departamento = g.First().Departamento.Nombre,
                    Total = g.Sum(x => x.Monto)
                })
                .ToListAsync();

            return Ok(gastos);
        }
    }

}
