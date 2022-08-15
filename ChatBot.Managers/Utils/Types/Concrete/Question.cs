using ChatBot.Dtos;
using ChatBot.Managers.Types.Abstracts;
using ChatBot.Managers.Utils.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Types.Concrete
{
    public class Question : IResolvable
    {
        string _question_id;
        Dictionary<string, string> _details;
        public Question(string question_id, Dictionary<string, string> details)
        {
            _question_id = question_id;
            _details = details;
        }
        public ChatBotResponseDTO Resolve()
        {
            return QuestionResolver.GetInstance().Resolve(this);
        }
    }
}
