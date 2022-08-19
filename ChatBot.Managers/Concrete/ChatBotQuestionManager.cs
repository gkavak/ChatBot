using AutoMapper;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Results.Concrete;
using ChatBot.Common.Utils.Results.ConcreteBase;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Constants;
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
        public async Task<IDataResult<ChatBotQuestionsDTO>> GetQuestion(string questionID)
        {
            var question =  await _questionDAL.FindByIdAsync(questionID);
            if(question != null)
            {
                var questionDto = _mapper.Map<ChatBotQuestionsDTO>(question);
                return new SuccessDataResult<ChatBotQuestionsDTO>(data: questionDto, message: MessageTexts.QuestionFound);
            }
            return new FailureDataResult<ChatBotQuestionsDTO>(message: MessageTexts.QuestionNotFound);
           
        }

      
    }
}
