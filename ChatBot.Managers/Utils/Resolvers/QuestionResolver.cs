using ChatBot.Dtos;
using ChatBot.Managers.Types.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Utils.Resolvers
{
    public sealed class QuestionResolver
    {
        private static QuestionResolver _instance;
        private QuestionResolver()
        {
            
        }
        public static QuestionResolver GetInstance()
        {
            if (_instance == null)
            {
                _instance = new QuestionResolver();
            }
            return _instance;
        }

        public ChatBotResponseDTO Resolve(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
