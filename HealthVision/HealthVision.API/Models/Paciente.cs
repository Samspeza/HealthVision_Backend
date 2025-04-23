using System.Collections.Generic;
using System;

public class Pacient
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<AnaliseImagem> Analises { get; set; }

    public ICollection<MedicalImage> MedicalImages { get; set; }
}
