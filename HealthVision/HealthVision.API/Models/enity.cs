public class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<AnaliseImagem> Analises { get; set; }
}

public class AnaliseImagem
{
    public int Id { get; set; }
    public string CaminhoImagem { get; set; }
    public string Resultado { get; set; }
    public DateTime DataAnalise { get; set; }
    public int PacienteId { get; set; }
}
