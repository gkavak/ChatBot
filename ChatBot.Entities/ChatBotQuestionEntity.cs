﻿using ChatBot.Common.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Entities
{
    public class ChatBotQuestionEntity:MsSQLDbEntity
    {

        public string NextMenuId { get; set; }

        public string Body { get; set; }
    }
}
