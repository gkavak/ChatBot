﻿using ChatBot.Common.DataAccess;
using ChatBot.DataLayer.Abstract;
using ChatBot.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.DataLayer.Concrete
{
    public class ChatBotQuestionDAL : MongoDbRepositoryBase<ChatBotQuestionEntity>, IChatBotQuestionDAL
    {
        public ChatBotQuestionDAL(IOptions<MongoDbSettings> options) : base(options)
        {

        }

    }
}