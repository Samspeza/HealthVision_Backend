using System;

public class AnaliseImagem
{
    public int Id { get; set; }
    public string CaminhoImagem { get; set; }
    public string Resultado { get; set; }
    public DateTime DataAnalise { get; set; } = DateTime.Now;
    public int PacienteId { get; set; }
    public Pacient Paciente { get; set; }

    public int MedicalImageId { get; set; }
    public MedicalImage MedicalImage { get; set; }
}
