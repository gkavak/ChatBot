public class UserController
{
    private readonly IUserRepository _userrepo;
    
    public UserController(IUserRepository repository)
    {
        _userrepo = repository;
    }
    public async Task<List<UserEntity>> Get() =>
             this._userrepo.Get();

    public async Task<UserEntity> Get(string id) =>
       this._userrepo.Get(u => u.Id == id);

    public async Task Create(UserEntity user) =>
        this._userrepo.AddAsync(user);

    public async Task Update(string id, UserEntity user) =>
        this._userrepo.UpdateAsync(id, user);

    public async Task Remove(string id) =>
        this._userrepo.DeleteAsync(id);
}