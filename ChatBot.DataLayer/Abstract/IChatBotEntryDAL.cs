using ChatBot.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Common.DataAccess;
using ChatBot.Entities;

namespace ChatBot.DataLayer.Abstract
{
    public interface IChatBotEntryDAL: IRepository<ChatBotEntryEntity, string>
    {
        
    }
}
