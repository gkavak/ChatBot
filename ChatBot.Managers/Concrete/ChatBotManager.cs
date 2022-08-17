﻿using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;

using ChatBot.Managers.Types.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Concrete
{
    public class ChatBotManager : IChatBotManager
    {
        private readonly IChatBotEntryDAL _chatBotEntryDal;
        private readonly IChatBotQuestionDAL _questionDAL;
        private readonly IMapper _mapper;

        public ChatBotManager(IChatBotQuestionDAL questionDAL,IChatBotEntryDAL chatBotEntryDal,IMapper mapper)
        {
            _questionDAL = questionDAL;
            _chatBotEntryDal = chatBotEntryDal;
            _mapper = mapper;
        }
        public async Task<ChatBotResponseDTO> AskQuestion(IResolvable menu_or_question)
        {
            //add chatbot entry

            // resolve
            return menu_or_question.Resolve();

        }
    }
}
