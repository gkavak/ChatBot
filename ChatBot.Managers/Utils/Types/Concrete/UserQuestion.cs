using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Types.Abstracts;
using ChatBot.Managers.Utils.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Types.Concrete
{
    public class UserQuestion : IResolvable
    {
        public string type { get; set; }
        public int id { get; set; }
        public int selectedQuestionId { get; set; }
        public string otherDetails { get; set; }

        public Task<ChatBotResponseDTO> Resolve(IChatBotQuestionManager questionManager, IMapper mapper)
        {
            if (this.type == "question")
                return Task.FromResult(QuestionResolver.GetInstance().Resolve(this, questionManager, mapper));
            else
                return MenuResolver.GetInstance().Resolve(this, questionManager, mapper);
        }
    }
}
