using AutoMapper;
using ChatBot.Dtos;
using ChatBot.Enitities;
using ChatBot.Entities;
using ChatBot.Managers.Utils.Types.Concrete;
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

            this.CreateMap<ChatBotResponse, ChatBotResponseDTO>()
                .ForMember(dto => dto.answer, act => act.MapFrom(nonDto => nonDto._answer))
                .ForMember(dto => dto.questions, act => act.MapFrom(nonDto => nonDto._questions))
                .ForMember(dto => dto.type, act => act.MapFrom(nonDto => nonDto._type));
    
        }
    }
}
