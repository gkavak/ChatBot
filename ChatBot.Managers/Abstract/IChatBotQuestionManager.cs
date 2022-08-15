using ChatBot.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Abstract
{
    public interface IChatBotQuestionManager
    {
        Task<ChatBotQuestionsDTO> GetQuestion(string questionID);
    }
}
