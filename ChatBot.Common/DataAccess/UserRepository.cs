public class UserRepository : IUserRepository
{
    public UserRepository(IOptions<MongoDbSettings> options)
    {
        base(options);
    }

    public string Authenticate() => "Token claimed!";
}