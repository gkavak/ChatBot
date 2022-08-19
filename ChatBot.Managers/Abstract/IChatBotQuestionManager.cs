using ChatBot.Common.Utils.Results.Abstract;
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
        Task<IDataResult<ChatBotQuestionsDTO>> GetQuestion(string questionID);
    }
}
