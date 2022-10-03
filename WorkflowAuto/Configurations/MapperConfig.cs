using AutoMapper;
using WorkflowAuto.Data;
using WorkflowAuto.Models;

namespace WorkflowAuto.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Application, ApplicationVM>().ReverseMap();
            CreateMap<Application, ApplicationIndexVM>().ReverseMap();
        }
    }
}
