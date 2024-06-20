using AutoMapper;
using SupportExample.DTOs;
using SupportExample.Models;

namespace SupportExample.Utilities;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Project, ProjectDto>().ReverseMap();
    }
}