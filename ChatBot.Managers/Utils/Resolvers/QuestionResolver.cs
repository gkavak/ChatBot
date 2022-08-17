using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Types.Concrete;
using ChatBot.Managers.Utils.Types.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Utils.Resolvers
{
    public sealed class QuestionResolver
    {
        private static Dictionary<string, string> question_answers_by_id;
        private static QuestionResolver _instance;
        private QuestionResolver()
        {
            CreateAnswers(question_answers_by_id);
        }
        public static QuestionResolver GetInstance()
        {
            if (_instance == null)
            {
                _instance = new QuestionResolver();
            }
            return _instance;
        }
        private void CreateAnswers(Dictionary<string, string> answer_map)
        {
            for (int i = 13; i <= 21; i++)
            {
                answer_map.Add(i.ToString(), $"Simple Question {i - 12} Answer");
            }
        }
        public ChatBotResponseDTO Resolve(Question question, IChatBotQuestionDAL questionDal, IMapper mapper)
        {
            string type = "answer";
            string answer = question_answers_by_id[question._question_id];
            return mapper.Map<ChatBotResponseDTO>(new ChatBotResponse( null,type = type, answer = answer));
            
        }
    }
}
