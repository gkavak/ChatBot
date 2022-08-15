using ChatBot.Common.DataAccess;
using ChatBot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.DataLayer.Abstract
{
    public interface IChatBotQuestionDAL:IRepository<ChatBotQuestionEntity, string>
    {
        
    }
   
}
