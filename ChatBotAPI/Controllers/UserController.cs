using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserManager _userManager;
    
    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    [HttpGet(Name ="GetUserByEmail")]
    public async Task<IDataResult<UserDto>> GetUserByEmail(string email) {
        return await this._userManager.GetUserByEmail(email);
    }
    [HttpPost(Name = "AddUser")]
    public async Task<ChatBot.Common.Utils.Results.Abstract.IResult> AddUser(UserDto user)
    {
        return await this._userManager.AddUserAsync(user);
    }
}