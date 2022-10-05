using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkflowAuto.Constants;

namespace WorkflowAuto.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                        Name = Roles.Administrator,
                        NormalizedName = Roles.Administrator.ToUpper()
                    },
                    new IdentityRole
                    {
                        Id = "c4194f76-1993-4a8d-8505-58cd21e73279",
                        Name = Roles.User,
                        NormalizedName = Roles.User.ToUpper()
                    }
                ); ;
        }
    }
}