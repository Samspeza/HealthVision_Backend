using AutoMapper;
using HealthVision.API.Models;
using HealthVision.API.DTOs;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Patient, PatientReadDto>();
        CreateMap<PatientCreateDto, Patient>();
    }
}
