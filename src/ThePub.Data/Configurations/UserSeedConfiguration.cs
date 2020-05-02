using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThePub.Data.Models;
using static ThePub.Data.Constants;

namespace ThePub.Data.Configurations
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Gosho",
                    LastName = "Goshev",
                    UserName = "gosho_goshev",
                    PasswordHash = Hasher.Create("Asd123"),
                    RoleId = OrdinaryRoleId
                }, 
                new User
                {
                    Id = 2,
                    FirstName = "Pesho",
                    LastName = "Peshov",
                    UserName = "pesho_peshov",
                    PasswordHash  = Hasher.Create("Asd123"),
                    RoleId = KnowsTheRightPeopleRoleId
                }
            );
        }
    }
}
