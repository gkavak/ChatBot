using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ChatBotQuestionController:ControllerBase
{
    private readonly IChatBotQuestionManager _chatBotQuestionManager;
    
    public ChatBotQuestionController(IChatBotQuestionManager chatBotQuestionManager)
    {
        _chatBotQuestionManager = chatBotQuestionManager;
    }

    [HttpGet(Name ="GetQuestion")]
    public Task<IDataResult<ChatBotQuestionsDTO>> GetQuestion(string questionID)
    {
        return _chatBotQuestionManager.GetQuestion(questionID);
    }

}