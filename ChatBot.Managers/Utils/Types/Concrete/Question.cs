using AutoMapper;
using ChatBot.DataLayer.Abstract;
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
        public string _question_id { get; }
        public Dictionary<string, string> _details { get; }
        public Question(string question_id, Dictionary<string, string> details)
        {
            _question_id = question_id;
            _details = details;
        }

        public Task<ChatBotResponseDTO> Resolve(IChatBotQuestionDAL questionDal, IMapper mapper)
        {
            return Task.FromResult(QuestionResolver.GetInstance().Resolve(this,questionDal,mapper));
        }
    }
}
