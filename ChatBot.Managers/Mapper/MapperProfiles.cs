using AutoMapper;
using ChatBot.Dtos;
using ChatBot.Enitities;
using ChatBot.Entities;
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
            this.CreateMap<ChatBotEntryEntity, ChatBotEntryDTO>();
            this.CreateMap<ChatBotEntryDTO, ChatBotEntryEntity>();
            this.CreateMap<ChatBotQuestionEntity, ChatBotQuestionsDTO>();
            this.CreateMap<ChatBotQuestionsDTO, ChatBotQuestionEntity>();
        }
    }
}
