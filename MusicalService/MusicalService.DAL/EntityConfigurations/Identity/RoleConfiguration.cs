using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicalService.Domain.Constants;
using MusicalService.Domain.DatabaseEntities.Identity;
using MusicalService.Identity.Enums;
using MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.Extensions;

namespace MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.EntityConfigurations.Identity;

internal sealed class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
{
    public void Configure(EntityTypeBuilder<RoleEntity> builder)
    {
        builder.ToTable("Role", DatabaseSchemes.Identity);

        builder.HasUniqueIdentifier<RoleEntity, long>();
        builder.HasName(100);
        
        HasData(builder);
    }

    // TODO
    private static void HasData(EntityTypeBuilder<RoleEntity> builder) //Should this function be static? or not?
    {
        builder.HasData(
            new RoleEntity
            {
                Id = (long)Roles.Admin,
                Name = Roles.Admin.ToString()
            },
            new RoleEntity
            {
                Id = (long)Roles.Dj,
                Name = Roles.Dj.ToString()
            },
            new RoleEntity
            {
                Id = (long)Roles.Listener,
                Name = Roles.Listener.ToString()
            },
            new RoleEntity
            {
                Id = (long)Roles.Musician,
                Name = Roles.Musician.ToString()
            }
        );
    }
}