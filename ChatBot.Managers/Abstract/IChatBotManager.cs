using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Types.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Abstract
{
    public interface IChatBotManager
    {
        Task<ChatBotResponseDTO> AskQuestionParsed(IResolvable menu_or_question);
        Task<IDataResult<ChatBotResponseDTO>> AskQuestion(UserQuestionDTO useranswer);
    }
}
