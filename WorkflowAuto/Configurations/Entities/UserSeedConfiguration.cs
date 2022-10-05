using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkflowAuto.Data;

namespace WorkflowAuto.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                    new Employee
                    {
                        Id = "0c4d579d-2758-48c4-848a-19afa675662f",
                        Email = "admin@localhost.com",
                        UserName = "admin@localhost.com",
                        NormalizedEmail = "ADMIN@LOCALHOST.COM",
                        NormalizedUserName = "ADMIN@LOCALHOST.COM",
                        FirstName = "System",
                        LastName = "Admin",
                        DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "P_ssw0rd1")
                    }                    
                );
        }
    }
}
