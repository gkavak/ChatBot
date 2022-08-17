using ChatBot.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Dtos
{
    public class ChatBotQuestionsDTO:DtoAbstract
    {

        
        public string NextMenuId { get; set; }

        public string Body { get; set; }
    }
}
