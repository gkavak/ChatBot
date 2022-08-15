using AutoMapper;
using ChatBot.DataLayer.Abstract;
using ChatBot.DataLayer.Concrete;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Concrete
{
    public class ChatBotEntryManager : IChatBotEntryManager
    {
        private readonly IChatBotEntryDAL _chatBotDal;
        private readonly IMapper _mapper;
        public ChatBotEntryManager(IChatBotEntryDAL chatBotDal, IMapper mapper)
        {
            _chatBotDal = chatBotDal;
            _mapper = mapper;
        }

        public void AddEntry(ChatBotEntryDTO entry)
        {
            throw new NotImplementedException();
        }

        public Task<ChatBotEntryDTO> GetEntryById(string entryID)
        {
            throw new NotImplementedException();
        }
    }
}
    
