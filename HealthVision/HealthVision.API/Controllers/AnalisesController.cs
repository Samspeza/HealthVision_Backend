using System.IO;
using System.Threading.Tasks;
using System;

[ApiController]
[Route("api/[controller]")]
public class AnalisesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _env;

    public AnalisesController(ApplicationDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    [HttpPost("upload/{pacienteId}")]
    public async Task<IActionResult> Upload(int pacienteId, IFormFile file)
    {
        var paciente = await _context.Pacientes.FindAsync(pacienteId);
        if (paciente == null) return NotFound("Paciente não encontrado");

        var imgDir = Path.Combine(_env.WebRootPath, "images");
        Directory.CreateDirectory(imgDir);

        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
        var filePath = Path.Combine(imgDir, fileName);

        using (var stream = System.IO.File.Create(filePath))
            await file.CopyToAsync(stream);

        var resultado = await IAIntegrationHelper.EnviarImagemAsync(filePath);

        var analise = new AnaliseImagem
        {
            CaminhoImagem = $"images/{fileName}",
            Resultado = resultado,
            PacienteId = pacienteId
        };

        _context.Analises.Add(analise);
        await _context.SaveChangesAsync();

        return Ok(analise);
    }
}
