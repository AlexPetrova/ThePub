using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThePub.Data.Models;
using static ThePub.Data.Constants;

namespace ThePub.Data.Configurations
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role { Id = OrdinaryRoleId, Name = "Ordinary" },
                new Role { Id = KnowsTheRightPeopleRoleId, Name = "KnowsTheRightPeople" }
            );
        }
    }
}
