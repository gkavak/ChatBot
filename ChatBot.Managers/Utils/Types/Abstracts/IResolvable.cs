using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Types.Abstracts
{
    public interface IResolvable
    {
        Task<ChatBotResponseDTO> Resolve(IChatBotQuestionManager questionManager, IMapper mapper);
    }
}
