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
        Task<ChatBotResponseDTO> AskQuestion(IResolvable menu_or_question);
        Task<ChatBotResponseDTO> AskQuestion(string useranswer);
    }
}
