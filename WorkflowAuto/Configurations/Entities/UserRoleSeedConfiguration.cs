using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkflowAuto.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                //System Admin
                new IdentityUserRole<string>
                    {
                        UserId = "0c4d579d-2758-48c4-848a-19afa675662f",
                        RoleId = "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                    }
                );
        }
    }
}
