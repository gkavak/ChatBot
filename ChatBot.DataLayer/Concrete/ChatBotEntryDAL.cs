using ChatBot.Common.DataAccess;
using ChatBot.DataLayer.Abstract;
using ChatBot.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.DataLayer.Concrete
{
    public class ChatBotEntryDAL : MongoDbRepositoryBase<ChatBotEntryEntity>, IChatBotEntryDAL
    {
        public ChatBotEntryDAL(IOptions<MongoDbSettings> options) : base(options)
        {

        }
    }
}
