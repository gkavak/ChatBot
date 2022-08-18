using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Dtos
{
    public class ChatBotResponseDTO
    {
        public string type { get; set; }

        public List<ChatBotQuestionsDTO> questions { get; set; }

        public string Id { get; set; }
        public string answer { get; set; }
    }
}
