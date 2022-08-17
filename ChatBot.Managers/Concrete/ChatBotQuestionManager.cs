using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Concrete
{
    public class ChatBotQuestionManager : IChatBotQuestionManager
    {
        private readonly IChatBotQuestionDAL _questionDAL;
        private readonly IMapper _mapper;
        public ChatBotQuestionManager(IChatBotQuestionDAL questionDAL, IMapper mapper)
        {
            _questionDAL = questionDAL;
            _mapper = mapper;
            
        }
        public async Task<ChatBotQuestionsDTO> GetQuestion(string questionID)
        {
            var question = await _questionDAL.FindByIdAsync(questionID);
            var questionDto = _mapper.Map<ChatBotQuestionsDTO>(question);
            
            return questionDto;
        }
    }
}
