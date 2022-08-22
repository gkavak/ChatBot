using AutoMapper;
using ChatBot.Common.Aspects.Autofac.Caching;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Results.Concrete;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.BusinessAspects.Autofac;
using ChatBot.Managers.Types.Abstracts;
using ChatBot.Managers.Types.Concrete;


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
        [SecuredOperation("question.ask")]
        
        public async Task<IDataResult<ChatBotResponseDTO>> AskQuestion(UserQuestionDTO userAnswers)
        {
            var question = _mapper.Map<UserQuestion>(userAnswers);

            var result = await AskQuestionParsed(question);
            if (result != null)
                return new SuccessDataResult<ChatBotResponseDTO>(data: result);
            else
                return new FailureDataResult<ChatBotResponseDTO>(message:"Could not find questions");
            
        }
    }
}
