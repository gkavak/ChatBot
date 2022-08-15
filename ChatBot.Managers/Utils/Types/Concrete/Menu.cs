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
        string _menu_id;
        Dictionary<string, string> _details;   
        public Menu(string menu_id,Dictionary<string,string> details)
        {
            _menu_id = menu_id;
            _details = details;
        }
        public ChatBotResponseDTO Resolve()
        {
            return MenuResolver.GetInstance().Resolve(this);
        }
    }
}
