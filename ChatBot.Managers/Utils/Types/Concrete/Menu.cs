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
    public class Menu : IResolvable
    {
        private string _menu_id { get; }
        private Dictionary<string, string> _details { get; }
        public Menu(string menu_id,Dictionary<string,string> details)
        {
            _menu_id = menu_id;
            _details = details;
        }
        public string GetMenuId()
        {
            return _menu_id;
        }
        public Dictionary<string, string> GetDetails()
        {
            return _details;
        }
        public Task<ChatBotResponseDTO> Resolve(IChatBotQuestionDAL questionDal,IMapper mapper)
        {
            return MenuResolver.GetInstance().Resolve(this,questionDal,mapper);
        }
    }
}
