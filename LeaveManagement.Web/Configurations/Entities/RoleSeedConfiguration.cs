using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace LeaveManagement.Web.Configurations.Entiies
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "2b60a25c-1623-4161-b544-b4c14163b120",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "cac43a7e-f7cb-4148-ba12-1acb431eabc1",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
                ) ;
        }
    }
}