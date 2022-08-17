using ChatBot.Common.DataAccess;
using ChatBot.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Entities
{
    [BsonCollection("ChatBotEntry")]
    public class ChatBotEntryEntity: MongoDbEntity
    {
        public string userID { get; set; }
        public string type { get; set; }
        public string QuestionOrMenuID { get; set; }
        public Dictionary<string,string> UserAnswers { get; set; }
    }
}
