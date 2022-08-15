using ChatBot.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Dtos
{
    public class ChatBotEntryDTO:DtoAbstract
    {
        public string userID { get; set; }
        public string type { get; set; }
        public string QuestionOrMenuID { get; set; }
        public Dictionary<string, string> UserAnswers { get; set; }
    }
}
