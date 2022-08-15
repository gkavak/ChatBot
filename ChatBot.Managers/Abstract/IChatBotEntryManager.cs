using ChatBot.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Abstract
{
    public interface IChatBotEntryManager
    {
        Task<ChatBotEntryDTO> GetEntryById(string entryID);
        void AddEntry(ChatBotEntryDTO entry);
    }
}
