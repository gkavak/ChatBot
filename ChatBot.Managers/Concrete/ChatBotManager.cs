using AutoMapper;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Results.Concrete;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;

using ChatBot.Managers.Types.Abstracts;
using ChatBot.Managers.Utils.JsonParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Concrete
{
    public class ChatBotManager : IChatBotManager
    {
        private readonly IChatBotEntryManager _chatBotEntryManager;
        private readonly IChatBotQuestionManager _questionManager;
        private readonly IMapper _mapper;

        public ChatBotManager(IChatBotQuestionManager questionManager, IChatBotEntryManager chatBotEntryManager, IMapper mapper)
        {
            _questionManager = questionManager;
            _chatBotEntryManager = chatBotEntryManager;
            _mapper = mapper;
        }
        public async Task<ChatBotResponseDTO> AskQuestionParsed(IResolvable menu_or_question)
        {
            //add chatbot entry

            // resolve
            return await menu_or_question.Resolve(_questionManager, _mapper);

        }
        public async Task<IDataResult<ChatBotResponseDTO>> AskQuestion(string userAnswers)
        {
            //parse with AOP ?
            var result = await AskQuestionParsed(JsonParser.ParseJSONToMenuOrQuestion(userAnswers));
            if (result != null)
                return new SuccessDataResult<ChatBotResponseDTO>(data: result);
            else
                return new FailureDataResult<ChatBotResponseDTO>(message:"Could not find questions");
            
        }
    }
}
