using Microsoft.EntityFrameworkCore;
using System.Linq;
using ThePub.Data;
using ThePub.Data.DTO;
using ThePub.Services.Contracts;

namespace ThePub.Services
{
    public class UserService : IUserService
    {
        private readonly PubDbContext context;

        public UserService(PubDbContext context)
        {
            this.context = context;
        }

        public UserDTO GetUser(string userName, string password)
        {
            var user = this.context.Users
                .Include(user => user.Role)
                .FirstOrDefault(user => user.UserName == userName);

            if (user == null || Hasher.Compare(password, user.PasswordHash))
            {
                return null;
            }
            else
            {
                return new UserDTO
                {
                    UserName = user.UserName,
                    FullName = $"{user.FirstName} {user.LastName}",
                    Role = user.Role.Name
                };
            }
        }
    }
}
