using System.Collections.Generic;
using System;

public class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<AnaliseImagem> Analises { get; set; }
}
