using ThePub.Data.DTO;

namespace ThePub.Services.Contracts
{
    public interface IUserService
    {
        UserDTO GetUser(string userName, string password);
    }
}
