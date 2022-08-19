using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ChatBotEntryController:ControllerBase
{
    private readonly IChatBotEntryManager _chatBotEntryManager;
    
    public ChatBotEntryController(IChatBotEntryManager chatBotEntryManager)
    {
        _chatBotEntryManager = chatBotEntryManager;
    }

    [HttpGet(Name ="GetEntryById")]
    public Task<IDataResult<ChatBotEntryDTO>> GetEntryById(string entryID)
    {
        throw new NotImplementedException();
    }

    [HttpPost(Name = "AddEntry")]
    public void AddEntry(ChatBotEntryDTO entry)
    {
        throw new NotImplementedException();
    }

}