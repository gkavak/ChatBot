using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserManager _userManager;
    
    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    [HttpGet("GetUserByEmail")]
    public async Task<IDataResult<UserDTO>> GetUserByEmail(string email) {
        return await this._userManager.GetUserByEmail(email);
    }
    [HttpPost("AddUser")]
    public async Task<ChatBot.Common.Utils.Results.Abstract.IResult> AddUser(UserDTO user)
    {
        return await this._userManager.AddUserAsync(user);
    }
}