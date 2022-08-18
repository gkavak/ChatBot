using ChatBot.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Utils.Types.Concrete
{
    public class ChatBotResponse
    {
        public string _type { get; set; }

        public List<ChatBotQuestionsDTO> _questions { get; set; }
        public string _Id { get; set; }
        public string _answer { get; set; }
        public ChatBotResponse(List<ChatBotQuestionsDTO> questions, string id,string type = "menu", string answer = null )
        {
            _type = type;
            _questions = questions;
            _answer = answer;
            _Id = id;
        }
    }
}
