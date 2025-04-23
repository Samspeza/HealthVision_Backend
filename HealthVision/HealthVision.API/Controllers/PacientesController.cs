using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class PacientesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public PacientesController(ApplicationDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Paciente>>> Get() =>
        await _context.Pacientes.Include(p => p.Analises).ToListAsync();

    [HttpPost]
    public async Task<ActionResult<Paciente>> Post(Paciente paciente)
    {
        _context.Pacientes.Add(paciente);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = paciente.Id }, paciente);
    }
}
