using AutoMapper;
using ChatBot.Dtos;
using ChatBot.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Mapper
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            this.CreateMap<UserEntity, UserDto>();
            this.CreateMap<UserDto, UserEntity>();
        }
    }
}
