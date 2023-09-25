using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Configurations.Entiies
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2b60a25c-1623-4161-b544-b4c14163b120",
                    UserId = "408aa945-3d84-4421-8342-7269ec64d947"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a7e-f7cb-4148-ba12-1acb431eabc1",
                    UserId = "3f4631bd-f907-4409-b416-ba356312e678"
                }
            );
        }
    }
}