
public interface IUserRepository : MongoDbRepositoryBase<UserEntity>
{
    string Authenticate();
}