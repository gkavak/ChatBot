using ChatBot.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Entities
{
    public class ChatBotEntryEntity: MongoDbEntity
    {
        public string Question { get; set; }
        public Dictionary<string,string> UserAnswers { get; set; }

        public string Respond { get; set; }
    }
}
