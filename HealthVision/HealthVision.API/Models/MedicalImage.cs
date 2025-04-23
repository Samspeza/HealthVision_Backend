using System;

public class MedicalImage
{
    public int Id { get; set; }
    public string ImagePath { get; set; }
    public DateTime UploadedAt { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public AnalysisResult AnalysisResult { get; set; }
}
