using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Entities;
using ChatBot.Managers.Types.Concrete;
using ChatBot.Managers.Utils.Types.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Utils.Resolvers
{
    public sealed class MenuResolver
    {
        private static MenuResolver _instance;
        private Dictionary<string, string> _menus;
        private string mapFilePath ="menu_maps.txt";

        private MenuResolver()
        {
            _menus = createMenuMap(mapFilePath);
        }
        public static MenuResolver GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MenuResolver();
            }
            return _instance;
        }


        private Dictionary<string, string> createMenuMap(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            Dictionary<string, string> map = new Dictionary<string, string>();
            string menu_id, question_ids_in_menu;
            foreach (string line in lines)
            {
                menu_id = line.Split(":")[0];
                question_ids_in_menu = line.Split(":")[1];
                map.Add(menu_id, question_ids_in_menu);
            }
            return map;
        }

        public List<string> GetQuestionListByMenuId(string menuId)
        {
            return _menus[menuId].Split(",").ToList();
        }
        public async Task<ChatBotResponseDTO> Resolve(Menu menu, IChatBotQuestionDAL questionDal, IMapper mapper)
        {
            //use questionDAL to get next menu id
            string questionId = menu.GetDetails()["selected_question_id"];
            var question = mapper.Map<ChatBotQuestionsDTO>(await questionDal.FindByIdAsync(questionId));
            string next_menu_id = question.NextMenuId;

           
            //get question ids included in the menu
            string[] question_ids = _menus[next_menu_id].Split(",");
            
            //create new menu
            List<ChatBotQuestionsDTO> questions = new List<ChatBotQuestionsDTO>();
            question_ids.Select(async qid => questions.Add(mapper.Map<ChatBotQuestionsDTO>(await questionDal.FindByIdAsync(qid))));


            //retrun new menu
            return mapper.Map<ChatBotResponseDTO>(new ChatBotResponse(questions, questions.Select(q=>q.NextMenuId ==null).Any() ? "question":"menu"));

        }
    }
}
