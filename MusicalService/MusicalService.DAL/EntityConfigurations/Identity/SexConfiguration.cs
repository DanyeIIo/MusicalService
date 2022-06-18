using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicalService.Domain.Constants;
using MusicalService.Domain.DatabaseEntities.Identity;
using MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.Extensions;

namespace MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.EntityConfigurations.Identity;

internal sealed class SexConfiguration
{
    public void Configure(EntityTypeBuilder<SexEntity> builder)
    {
        builder.ToTable("Sex", DatabaseSchemes.Identity);

        builder.HasUniqueIdentifier<SexEntity, int>();
        builder.HasName(21);
        builder.Property(e => e.Id).HasColumnType("smallint").IsRequired();
    }
}